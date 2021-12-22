using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BM_Medical.Models;
using BM_Medical.Data;

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
            var objList = (this.Context.Categories).ToList();
            return View(objList);
        }

    }
}
