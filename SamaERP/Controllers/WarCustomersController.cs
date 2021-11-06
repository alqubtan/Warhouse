using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SamaERP.Data;
using SamaERP.Models;

namespace SamaERP.Controllers
{
    public class WarCustomersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WarCustomersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WarCustomers
        public async Task<IActionResult> Index()
        {
            return View(await _context.WarCustomer.ToListAsync());
        }

        // GET: WarCustomers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warCustomer = await _context.WarCustomer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warCustomer == null)
            {
                return NotFound();
            }

            return View(warCustomer);
        }

        // GET: WarCustomers/Create
        public IActionResult Create()
        {
            // get all customers types
            var customerTypes = _context.WarCustomerType.ToList();

            ViewBag.customerTypes = new SelectList(customerTypes, "CustomerType", "CustomerType");
            return View();
        }

        // POST: WarCustomers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustomerName,CustomerType,CustomerDepartment,CustomerDecription,CustomerPhoneNo,CustomerEmail,CustomerAddress,CustomerCountry,CustomerCity")] WarCustomer warCustomer)
        {
            if (ModelState.IsValid)
            {
                var new_name = warCustomer.CustomerName.Trim();
                var isExist = _context.WarCustomer.Any(o => o.CustomerName == new_name);

                if (isExist)
                {
                    ViewBag.exist_err = "customer already exist";
                    return View();
                }
                warCustomer.Id = Guid.NewGuid();
                _context.Add(warCustomer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(warCustomer);
        }

        // GET: WarCustomers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warCustomer = await _context.WarCustomer.FindAsync(id);
            if (warCustomer == null)
            {
                return NotFound();
            }
            return View(warCustomer);
        }

        // POST: WarCustomers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,CustomerName,CustomerType,CustomerDepartment,CustomerDecription,CustomerPhoneNo,CustomerEmail,CustomerAddress,CustomerCountry,CustomerCity")] WarCustomer warCustomer)
        {
            if (id != warCustomer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(warCustomer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarCustomerExists(warCustomer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(warCustomer);
        }

        // GET: WarCustomers/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warCustomer = await _context.WarCustomer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warCustomer == null)
            {
                return NotFound();
            }

            return View(warCustomer);
        }

        // POST: WarCustomers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var warCustomer = await _context.WarCustomer.FindAsync(id);
            _context.WarCustomer.Remove(warCustomer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WarCustomerExists(Guid id)
        {
            return _context.WarCustomer.Any(e => e.Id == id);
        }
    }
}
