using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BM_Medical.Models;

namespace BM_Medical.Controllers
{
    public class ShopController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ShopController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

    }
}
