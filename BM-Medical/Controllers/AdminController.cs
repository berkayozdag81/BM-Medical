using BM_Medical.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using BM_Medical_Handler.Data;
using System;
using System.IO;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Authorization;

namespace BM_Medical.Controllers
{
    [Authorize(Roles = "Admin")]
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
            if (true)
            {
                ViewBag.UserCount = this.Context.Users.Count();
                ViewBag.ProductCount = this.Context.Products.Count();
                return View();
            }

            return Redirect("/Home/Index");
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
        public IActionResult CategoryEdit(Category category)
        {
            var entity = new Category()
            {
                Id = category.Id,
                Ad = category.Ad,

            };
            if (category != null)
            {
                this.Context.Categories.Attach(entity);
                this.Context.Entry(entity).Property(x => x.Ad).IsModified = true;
                this.Context.SaveChanges();
            }
            return Redirect("/Admin/CategoryList");
        }





        [HttpPost]
        public IActionResult ProductCreate(Product product)
        {
            var a = _hostingEnvironment.WebRootPath;
            var fileName = product.Image.FileName;
            var filePath = Path.Combine(_hostingEnvironment.WebRootPath, "C:/Users/BERKAY/Desktop/BM-Medical/BM-Medical/BM-Medical/wwwroot/lib/bootstrap/dist/img/products", fileName);

            using (var fileSteam = new FileStream(filePath, FileMode.Create))
            {
                product.Image.CopyToAsync(fileSteam);
            }



            var entity = new Product()
            {
                Ad = product.Ad,
                Category = product.Category,
                Stok = product.Stok,
                Fiyat = product.Fiyat,
                Aciklama = product.Aciklama,
                ImageUrl = product.Image.FileName
            };
            this.Context.Products.Add(entity);
            this.Context.SaveChanges();
            return Redirect("/Admin/ProductList");
        }
        public IActionResult ProductList()
        {

            var objList = (this.Context.Products).ToList();
            //objList[0].ImageUrl = "dezenfektan1.2.jpg";
            return View(objList);
        }
        public IActionResult ProductDelete(int Id)
        {
            var product = this.Context.Products.Find(Id);
            if (product != null)
            {
                this.Context.Products.Remove(product);
                this.Context.SaveChanges();
            }
            return Redirect("/Admin/ProductList");
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
