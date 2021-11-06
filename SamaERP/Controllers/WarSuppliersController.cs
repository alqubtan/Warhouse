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
    public class WarSuppliersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WarSuppliersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WarSuppliers
        public async Task<IActionResult> Index()
        {
            return View(await _context.WarSupplier.ToListAsync());
        }

        // GET: WarSuppliers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warSupplier = await _context.WarSupplier
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warSupplier == null)
            {
                return NotFound();
            }

            return View(warSupplier);
        }

        // GET: WarSuppliers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WarSuppliers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SupplierName,SupplierType,SupplierDescription,SupplierPhoneNo,SupplierEmail,SupplierAddress,SupplierCountry,SupplierCity")] WarSupplier warSupplier)
        {
            if (ModelState.IsValid)
            {
                var new_name = warSupplier.SupplierName.Trim();
                var isExist = _context.WarSupplier.Any(o => o.SupplierName == new_name);

                if (isExist)
                {
                    ViewBag.exist_err = "supplier already exist";
                    return View();
                }
                warSupplier.Id = Guid.NewGuid();
                _context.Add(warSupplier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(warSupplier);
        }

        // GET: WarSuppliers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warSupplier = await _context.WarSupplier.FindAsync(id);
            if (warSupplier == null)
            {
                return NotFound();
            }
            return View(warSupplier);
        }

        // POST: WarSuppliers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,SupplierName,SupplierType,SupplierDescription,SupplierPhoneNo,SupplierEmail,SupplierAddress,SupplierCountry,SupplierCity")] WarSupplier warSupplier)
        {
            if (id != warSupplier.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(warSupplier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarSupplierExists(warSupplier.Id))
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
            return View(warSupplier);
        }

        // GET: WarSuppliers/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warSupplier = await _context.WarSupplier
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warSupplier == null)
            {
                return NotFound();
            }

            return View(warSupplier);
        }

        // POST: WarSuppliers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var warSupplier = await _context.WarSupplier.FindAsync(id);
            _context.WarSupplier.Remove(warSupplier);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WarSupplierExists(Guid id)
        {
            return _context.WarSupplier.Any(e => e.Id == id);
        }
    }
}
