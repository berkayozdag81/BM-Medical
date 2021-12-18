using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM_Medical.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryList()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            return View();
        }
        public IActionResult UserList()
        {
            return View();
        }
    }
}
