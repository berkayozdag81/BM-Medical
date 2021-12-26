using BM_Medical.Models;
using BM_Medical_Handler.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

[assembly:ApiController]
namespace BM_Medical_WebApi.Controllers
{
    public class MedicalController
    {
        private ApplicationDbContext Context { get; }
        public MedicalController(ApplicationDbContext _context)
        {
            this.Context = _context;
        }

        //[HttpGet]
        //[Route("api/BM/GetCategoryList")]
        //public async Task<List<Category>> MyApi()
        //{
        //    var objList = await (Context.Categories).ToList();
        //    return objList;
        //}

        //[HttpGet]
        //[Route("api/BM/GetCategoryList")]
        //public IEnumerable<Category> Get()
        //{
        //    var objList = (this.Context.Categories).ToList();
        //    return objList;
        //}


        //[HttpGet]
        //[Route("api/BM/GetProduct/")]
        //public IHttpActionResult Get()
        //{
        //    var entity = new Category()
        //    {
        //        Ad = category.Ad,
        //    };
        //    this.Context.Categories.Add(entity);
        //    this.Context.SaveChanges();
        //    return Json(new { Message ="Success" });
        //}

    }

}

