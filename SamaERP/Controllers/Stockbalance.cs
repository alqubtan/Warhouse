using Microsoft.AspNetCore.Mvc;
using SamaERP.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SamaERP.Controllers
{
    public class Stockbalance : Controller
    {
        private readonly ApplicationDbContext _context;

        public Stockbalance(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var inproducts = _context.WarReceivedProduct.ToList();
            var outproducts = _context.WarDeliverd.ToList();
            ViewBag.inProducts = inproducts;
            ViewBag.outproducts = outproducts;

             ViewBag.totalIn = inproducts.Sum(o => o.ProductQty);
            ViewBag.totalOut = outproducts.Sum(o => o.Quantity);
            ViewBag.res = ViewBag.totalIn - ViewBag.totalOut;




            return View();
        }

    }
}
