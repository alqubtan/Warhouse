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
    public class WarSupplierTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WarSupplierTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WarSupplierTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.WarSupplierType.ToListAsync());
        }

        // GET: WarSupplierTypes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warSupplierType = await _context.WarSupplierType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warSupplierType == null)
            {
                return NotFound();
            }

            return View(warSupplierType);
        }

        // GET: WarSupplierTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WarSupplierTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SupplierType,SupplierDescription")] WarSupplierType warSupplierType)
        {
            if (ModelState.IsValid)
            {
                var new_name = warSupplierType.SupplierType.Trim();
                var isExist = _context.WarSupplierType.Any(o => o.SupplierType == new_name);

                if (isExist)
                {
                    ViewBag.exist_err = "type already exist";
                    return View();
                }
                warSupplierType.Id = Guid.NewGuid();
                _context.Add(warSupplierType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(warSupplierType);
        }

        // GET: WarSupplierTypes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warSupplierType = await _context.WarSupplierType.FindAsync(id);
            if (warSupplierType == null)
            {
                return NotFound();
            }
            return View(warSupplierType);
        }

        // POST: WarSupplierTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,SupplierType,SupplierDescription")] WarSupplierType warSupplierType)
        {
            if (id != warSupplierType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(warSupplierType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarSupplierTypeExists(warSupplierType.Id))
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
            return View(warSupplierType);
        }

        // GET: WarSupplierTypes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warSupplierType = await _context.WarSupplierType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warSupplierType == null)
            {
                return NotFound();
            }

            return View(warSupplierType);
        }

        // POST: WarSupplierTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var warSupplierType = await _context.WarSupplierType.FindAsync(id);
            _context.WarSupplierType.Remove(warSupplierType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WarSupplierTypeExists(Guid id)
        {
            return _context.WarSupplierType.Any(e => e.Id == id);
        }
    }
}
