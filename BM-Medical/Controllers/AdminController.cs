using BM_Medical.Data;
using BM_Medical.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM_Medical.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext Context { get; }
        public AdminController(ApplicationDbContext _context)
        {
            this.Context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CategoryCreate(Category category)
        {
            var entity = new Category()
            {
                Ad = category.Ad,
            };
            this.Context.Categories.Add(entity);
            this.Context.SaveChanges();
            return Redirect("/Admin/CategoryList");
        }
        [HttpGet]
        public IActionResult CategoryEdit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var category = this.Context.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
            var model = new Category()
            {
                Id = category.Id,
                Ad = category.Ad,
            };
            return View(model);
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
