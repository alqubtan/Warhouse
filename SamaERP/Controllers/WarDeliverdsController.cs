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
    public class WarDeliverdsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WarDeliverdsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WarDeliverds
        public async Task<IActionResult> Index()
        {
            return View(await _context.WarDeliverd.ToListAsync());
        }

        // GET: WarDeliverds/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warDeliverd = await _context.WarDeliverd
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warDeliverd == null)
            {
                return NotFound();
            }

            return View(warDeliverd);
        }

        // GET: WarDeliverds/Create
        public IActionResult Create()
        {
            var products = _context.WarReceivedProduct.ToList();
            var warehouses = _context.Warehouse.ToList();
            var branches = _context.WarBranch.ToList();
            var customers = _context.WarCustomer.ToList();
            ViewBag.products = new SelectList(products, "ProductName", "ProductName");
            ViewBag.warehouses = new SelectList(warehouses, "WarhouseName", "WarhouseName");
            ViewBag.branches = new SelectList(branches, "BranchName", "BranchName");
            ViewBag.customers = new SelectList(customers, "CustomerName", "CustomerName");
            return View();
        }

         [HttpPost]
        public async Task<ActionResult> GetUnit(string productName)
        {
            WarProduct product = await _context.WarProduct.Where(o => o.ProductName == productName).FirstOrDefaultAsync();

            
            //data.Add(productUnit);


            return Json(product.Prod_MeasureUnit);
        }

        // POST: WarDeliverds/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductName, CustomerName,SerialNo,Barcode,Unit,Quantity,BranchName,WarehouseName,DeliverDate,OrderDate,OrderNumber,ActiveOrNot")] WarDeliverd warDeliverd)
        {
            if (ModelState.IsValid)
            {
                // check if there is avilable amount for this request
                var product = _context.WarReceivedProduct.Where(o => o.ProductName == warDeliverd.ProductName && o.BranchName == warDeliverd.BranchName && o.WarehouseName == warDeliverd.WarehouseName).FirstOrDefault();

                if (product != null)
                {

                    // *** if the requested value bigger than the stored value return message ***
                    if (product.ProductQty < warDeliverd.Quantity)
                    {
                        ViewBag.notEnough = "There is no engough quantity.";
                        return View();
                    }
                    // *** Else : except the request. and add this to list ***

                    warDeliverd.ActiveOrNot = 1;
                    warDeliverd.Id = Guid.NewGuid();
                    _context.Add(warDeliverd);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }

                ViewBag.notExistProduct = "Product not avilable.";

               
            }
            return View(warDeliverd);
        }

        // GET: WarDeliverds/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warDeliverd = await _context.WarDeliverd.FindAsync(id);
            if (warDeliverd == null)
            {
                return NotFound();
            }
            return View(warDeliverd);
        }

        // POST: WarDeliverds/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,SerialNo,Barcode,Unit,Quantity,BranchName,WarehouseName,DeliverDate,OrderDate,OrderNumber,ActiveOrNot")] WarDeliverd warDeliverd)
        {
            if (id != warDeliverd.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(warDeliverd);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WarDeliverdExists(warDeliverd.Id))
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
            return View(warDeliverd);
        }

        // GET: WarDeliverds/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var warDeliverd = await _context.WarDeliverd
                .FirstOrDefaultAsync(m => m.Id == id);
            if (warDeliverd == null)
            {
                return NotFound();
            }

            return View(warDeliverd);
        }

        // POST: WarDeliverds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var warDeliverd = await _context.WarDeliverd.FindAsync(id);
            _context.WarDeliverd.Remove(warDeliverd);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WarDeliverdExists(Guid id)
        {
            return _context.WarDeliverd.Any(e => e.Id == id);
        }
    }
}
