using BM_Medical.Models;
using BM_Medical_Handler.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BM_Medical.Controllers
{
    public class ShopController : Controller
    {
        private ApplicationDbContext Context { get; }
        public ShopController(ApplicationDbContext _context)
        {
            this.Context = _context;
        }
        public IActionResult Index()
        {
            var objList = (this.Context.Products).ToList();
            ViewBag.Categories = (this.Context.Categories).ToList();
            return View(objList);
        }

        [HttpGet]
        public IActionResult OrderCreate(int productId)
        {
            Product product = this.Context.Products.Find(productId);
            var user = User.Identity.Name;
            var entity = new Order()
            {
                ToplamUcret = product.Fiyat,
                SiparisTarihi = DateTime.Now,
                UserName = user,
            };
            this.Context.Orders.Add(entity);
            this.Context.SaveChanges();
            return Redirect("/Shop/Index");
        }

    }
}
