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
    public class WarBranchesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WarBranchesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WarBranches
        public async Task<IActionResult> Index()
        {
            return View(await _context.WarBranch.ToListAsync());
        }

        // GET: WarBranches/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warBranch = await _context.WarBranch
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warBranch == null)
            {
                return NotFound();
            }

            // get warehouses of that branch 
            var warehouses = await _context.Warehouse.Where(O => O.WarehouseBranch == warBranch.BranchName).ToListAsync();
            ViewBag.warehouses = warehouses;
            return View(warBranch);
        }

        // GET: WarBranches/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: WarBranches/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BranchName,BranchAdresss,BranchCity,BranchCountry")] WarBranch warBranch)
        {
            if (ModelState.IsValid)
            {
                var new_name = warBranch.BranchName.Trim();
                var isExist =  _context.WarBranch.Any(o => o.BranchName == new_name);

                if (isExist)
                {
                    ViewBag.exist_err = "branch already exist";
                    return View();
                }
                warBranch.Id = Guid.NewGuid();
                _context.Add(warBranch);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(warBranch);
        }

        // GET: WarBranches/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warBranch = await _context.WarBranch.FindAsync(id);
            if (warBranch == null)
            {
                return NotFound();
            }
            return View(warBranch);
        }

        // POST: WarBranches/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,BranchName,BranchAdresss,BranchCity,BranchCountry")] WarBranch warBranch)
        {
            if (id != warBranch.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(warBranch);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarBranchExists(warBranch.Id))
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
            return View(warBranch);
        }

        // GET: WarBranches/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warBranch = await _context.WarBranch
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warBranch == null)
            {
                return NotFound();
            }

            return View(warBranch);
        }

        // POST: WarBranches/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var warBranch = await _context.WarBranch.FindAsync(id);
            _context.WarBranch.Remove(warBranch);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WarBranchExists(Guid id)
        {
            return _context.WarBranch.Any(e => e.Id == id);
        }
    }
}
