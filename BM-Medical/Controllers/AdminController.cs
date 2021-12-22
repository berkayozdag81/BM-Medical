using BM_Medical.Data;
using BM_Medical.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace BM_Medical.Controllers
{
    public class AdminController : Controller
    {
        private ApplicationDbContext Context { get; }
        private readonly IWebHostEnvironment _hostingEnvironment;
        public AdminController(ApplicationDbContext _context, IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
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
        public IActionResult CategoryList()
        {
            var objList = (this.Context.Categories).ToList();
            return View(objList);
        }
        public IActionResult CategoryDelete(int Id)
        {
            var category = this.Context.Categories.Find(Id);
            if (category != null)
            {
                this.Context.Categories.Remove(category);
                this.Context.SaveChanges();
            }
            return Redirect("/Admin/CategoryList");
        }






        [HttpPost]
        public IActionResult ProductCreate(Product product)
        {
            var entity = new Product()
            {
                Ad = product.Ad,
                Category = product.Category,
                Stok = product.Stok,
                Fiyat = product.Fiyat,
                Aciklama = product.Aciklama,
                Image = product.Image
            };
            this.Context.Products.Add(entity);
            this.Context.SaveChanges();
            return Redirect("/Admin/ProductList");
        }
        public IActionResult ProductList()
        {
            var objList = (this.Context.Products).ToList();
            return View(objList);
        }







        [HttpPost]
        public IActionResult UserCreate(User user)
        {
            var entity = new User()
            {
                UserName = user.UserName,
                Soyad = user.Soyad,
                Adres = user.Adres,
                Sehir = user.Sehir,
                Email = user.Email,
            };
            this.Context.Users.Add(entity);
            this.Context.SaveChanges();
            return Redirect("/Admin/UserList");
        }
        public IActionResult UserList()
        {
            var objList = (this.Context.Users).ToList();
            return View(objList);
        }

        public IActionResult UserDelete(string UserId)
        {
            var user = this.Context.Users.Find(UserId);
            if (user != null)
            {
                this.Context.Users.Remove(user);
                this.Context.SaveChanges();
            }
            return Redirect("/Admin/UserList");
        }
    }
}
