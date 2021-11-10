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
    public class WarReceivedProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WarReceivedProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WarReceivedProducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.WarReceivedProduct.ToListAsync());
        }

        // GET: WarReceivedProducts/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warReceivedProduct = await _context.WarReceivedProduct
                .FirstOrDefaultAsync(m => m.ID == id);
            if (warReceivedProduct == null)
            {
                return NotFound();
            }

            return View(warReceivedProduct);
        }

        // GET: WarReceivedProducts/Create
        public IActionResult Create()
        {
            // get, products , branches , warehouses,  suppliers AS DROPDOWN LISTS

            var products =  _context.WarProduct.ToList();
            var suppliers = _context.WarSupplier.ToList();
            var branches = _context.WarBranch.ToList();
            var warehouses = _context.Warehouse.ToList();


            ViewBag.products = new SelectList(products, "ProductName", "ProductName");
            ViewBag.suppliers = new SelectList(suppliers, "SupplierName", "SupplierName");
            ViewBag.branches = new SelectList(branches, "BranchName", "BranchName");
            ViewBag.warehouses = new SelectList(warehouses, "WarhouseName", "WarhouseName");
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> GetUnit(string productName)
        {
            WarProduct product = await _context.WarProduct.Where(o => o.ProductName == productName).FirstOrDefaultAsync();

            
            //data.Add(productUnit);


            return Json(product.Prod_MeasureUnit);
        }

        // POST: WarReceivedProducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public async Task<IActionResult> Create([Bind("ID,ProductName,SNumber,ProductBarcode,ProductSupplier,ProductUnit,ProductQty,RecivedPrice,TotalPrice,BranchName,WarehouseName,ProductExpireDate,RecivedDate,InvoiceNumber,InvoiceDate")] WarReceivedProduct warReceivedProduct)
        {
            // get, products , branches , warehouses,  suppliers AS DROPDOWN LISTS

            var products = _context.WarProduct.ToList();
            ViewBag.products = new SelectList(products, "ProductName", "ProductName");
            var suppliers = _context.WarSupplier.ToList();
            ViewBag.suppliers = new SelectList(suppliers, "SupplierName", "SupplierName");
            var branches = _context.WarBranch.ToList();
            ViewBag.branches = new SelectList(branches, "BranchName", "BranchName");
            var warehouses = _context.Warehouse.ToList();
            ViewBag.warehouses = new SelectList(warehouses, "WarhouseName", "WarhouseName");
            if (ModelState.IsValid)
            {
                
                //var new_name = warReceivedProduct.ProductName.Trim();
                //var isExist = _context.WarReceivedProduct.Any(o => o.ProductName == new_name);

                //if (isExist)
                //{
                //    ViewBag.exist_err = "Product already exist";
                //    return View();
                //}
                warReceivedProduct.ID = Guid.NewGuid();
                _context.Add(warReceivedProduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(warReceivedProduct);
        }

        // GET: WarReceivedProducts/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warReceivedProduct = await _context.WarReceivedProduct.FindAsync(id);
            if (warReceivedProduct == null)
            {
                return NotFound();
            }
            var suppliers = _context.WarSupplier.ToList();
            var branches = _context.WarBranch.ToList();
            var warehouses = _context.Warehouse.ToList();
            ViewBag.suppliers = suppliers;
            ViewBag.branches = branches;
            ViewBag.warehouses = warehouses;
            return View(warReceivedProduct);
        }

        // POST: WarReceivedProducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ID,ProductName,SNumber,ProductBarcode,ProductSupplier,ProductUnit,ProductQty,RecivedPrice,TotalPrice,BranchName,WarehouseName,ProductExpireDate,RecivedDate,InvoiceNumber,InvoiceDate")] WarReceivedProduct warReceivedProduct)
        {
            if (id != warReceivedProduct.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(warReceivedProduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarReceivedProductExists(warReceivedProduct.ID))
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
            return View(warReceivedProduct);
        }

        // GET: WarReceivedProducts/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warReceivedProduct = await _context.WarReceivedProduct
                .FirstOrDefaultAsync(m => m.ID == id);
            if (warReceivedProduct == null)
            {
                return NotFound();
            }

            return View(warReceivedProduct);
        }

        // POST: WarReceivedProducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var warReceivedProduct = await _context.WarReceivedProduct.FindAsync(id);
            _context.WarReceivedProduct.Remove(warReceivedProduct);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WarReceivedProductExists(Guid id)
        {
            return _context.WarReceivedProduct.Any(e => e.ID == id);
        }
    }
}
