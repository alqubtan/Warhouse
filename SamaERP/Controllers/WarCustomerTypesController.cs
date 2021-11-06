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
    public class WarCustomerTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WarCustomerTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WarCustomerTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.WarCustomerType.ToListAsync());
        }

        // GET: WarCustomerTypes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warCustomerType = await _context.WarCustomerType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warCustomerType == null)
            {
                return NotFound();
            }

            return View(warCustomerType);
        }

        // GET: WarCustomerTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WarCustomerTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CustomerType,CustomerTypeDescription")] WarCustomerType warCustomerType)
        {
            if (ModelState.IsValid)
            {
                var new_name = warCustomerType.CustomerType.Trim();
                var isExist = _context.WarCustomerType.Any(o => o.CustomerType == new_name);

                if (isExist)
                {
                    ViewBag.exist_err = "customer type already exist";
                    return View();
                }
                warCustomerType.Id = Guid.NewGuid();
                _context.Add(warCustomerType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(warCustomerType);
        }

        // GET: WarCustomerTypes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warCustomerType = await _context.WarCustomerType.FindAsync(id);
            if (warCustomerType == null)
            {
                return NotFound();
            }
            return View(warCustomerType);
        }

        // POST: WarCustomerTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,CustomerType,CustomerTypeDescription")] WarCustomerType warCustomerType)
        {
            if (id != warCustomerType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(warCustomerType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarCustomerTypeExists(warCustomerType.Id))
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
            return View(warCustomerType);
        }

        // GET: WarCustomerTypes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warCustomerType = await _context.WarCustomerType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warCustomerType == null)
            {
                return NotFound();
            }

            return View(warCustomerType);
        }

        // POST: WarCustomerTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var warCustomerType = await _context.WarCustomerType.FindAsync(id);
            _context.WarCustomerType.Remove(warCustomerType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WarCustomerTypeExists(Guid id)
        {
            return _context.WarCustomerType.Any(e => e.Id == id);
        }
    }
}
