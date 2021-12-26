using Microsoft.AspNetCore.Mvc;
using BM_Medical.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;
using BM_Medical_WebApi_Core.Data;

namespace BM_Medical_WebApi_Core.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private ApplicationDbContext Context { get; }
        public ValuesController(ApplicationDbContext _context )
        {
           
            this.Context = _context;
        }

        //[HttpGet]
        //public IEnumerable<int> GetCategoryList()
        //{
        //    // var objList = (this.Context.Categories).ToList();
        //    List<int> sayilar = new List<int>();
        //    sayilar.Add(12);
        //    sayilar.Add(42);
        //    sayilar.Add(32);
        //    sayilar.Add(89);
        //    return sayilar;
        //}


        [HttpGet]
        public IEnumerable<Category> GetList()
        {            
            var objList = (this.Context.Categories).ToList();
            //Category cat = new Category();
            //cat.Ad = "met";
            //cat.Id = 1;
            //List<Category> catlist = new List<Category>();
            //catlist.Add(cat);
            return objList;
        }
    }
}
