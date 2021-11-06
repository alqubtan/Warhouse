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
    public class WarProductTypesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WarProductTypesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WarProductTypes
        public async Task<IActionResult> Index()
        {
            return View(await _context.WarProductType.ToListAsync());
        }

        // GET: WarProductTypes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warProductType = await _context.WarProductType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warProductType == null)
            {
                return NotFound();
            }

            return View(warProductType);
        }

        // GET: WarProductTypes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WarProductTypes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,productType,productTypeDescription")] WarProductType warProductType)
        {
            if (ModelState.IsValid)
            {
                warProductType.Id = Guid.NewGuid();
                _context.Add(warProductType);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(warProductType);
        }

        // GET: WarProductTypes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warProductType = await _context.WarProductType.FindAsync(id);
            if (warProductType == null)
            {
                return NotFound();
            }
            return View(warProductType);
        }

        // POST: WarProductTypes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,productType,productTypeDescription")] WarProductType warProductType)
        {
            if (id != warProductType.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(warProductType);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarProductTypeExists(warProductType.Id))
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
            return View(warProductType);
        }

        // GET: WarProductTypes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warProductType = await _context.WarProductType
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warProductType == null)
            {
                return NotFound();
            }

            return View(warProductType);
        }

        // POST: WarProductTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var warProductType = await _context.WarProductType.FindAsync(id);
            _context.WarProductType.Remove(warProductType);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WarProductTypeExists(Guid id)
        {
            return _context.WarProductType.Any(e => e.Id == id);
        }
    }
}
