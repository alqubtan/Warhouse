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
    public class WarProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WarProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WarProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.WarProduct.ToListAsync());
        }

        // GET: WarProducts/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warProduct = await _context.WarProduct
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warProduct == null)
            {
                return NotFound();
            }

            return View(warProduct);
        }

        // GET: WarProducts/Create
        public IActionResult Create()
        {
            // get all projects types
            var productTypes = _context.WarProductType.ToList();
            ViewBag.productTypes = new SelectList(productTypes, "productType", "productType");
            return View();
        }

        // POST: WarProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductName,ProductDescription,ProductType,Prod_MeasureUnit,HasExpireDate,ProductExpireDate")] WarProduct warProduct)
        {
            // get all projects types
            var productTypes = _context.WarProductType.ToList();
            ViewBag.productTypes = new SelectList(productTypes, "productType", "productType");
            if (ModelState.IsValid)
            {
               
                // check if product name is already exist
                var new_name = warProduct.ProductName.Trim();
                var isExist = _context.WarProduct.Any(o => o.ProductName == new_name);

                if (isExist)
                {
                    ViewBag.exist_err = "Product already exist";
                    return View();
                }

                warProduct.Id = Guid.NewGuid();
                _context.Add(warProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(warProduct);
        }

        // GET: WarProducts/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warProduct = await _context.WarProduct.FindAsync(id);
            if (warProduct == null)
            {
                return NotFound();
            }
            return View(warProduct);
        }

        // POST: WarProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,ProductName,ProductDescription,ProductType,Prod_MeasureUnit,HasExpireDate,AlSaderDate")] WarProduct warProduct)
        {
            if (id != warProduct.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(warProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarProductExists(warProduct.Id))
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
            return View(warProduct);
        }

        // GET: WarProducts/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warProduct = await _context.WarProduct
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warProduct == null)
            {
                return NotFound();
            }

            return View(warProduct);
        }

        // POST: WarProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var warProduct = await _context.WarProduct.FindAsync(id);
            _context.WarProduct.Remove(warProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WarProductExists(Guid id)
        {
            return _context.WarProduct.Any(e => e.Id == id);
        }
    }
}
