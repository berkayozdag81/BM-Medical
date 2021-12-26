using BM_Medical.Models;
using BM_Medical_Handler.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BM_Medical_WebApi_Core.Controllers
{
  
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private ApplicationDbContext Context { get; }

        public CategoryController(ApplicationDbContext _context)
        {
            this.Context = _context;
        }
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ILogger<CategoryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            Category cat = new Category();
            cat.Ad ="met";
            cat.Id = 1;
            List<Category> catlist = new List<Category>();
            catlist.Add(cat);
            return catlist;
        }

        //[HttpGet]
        //public IEnumerable<string> getStr()
        //{
          
        //    return new string[] { "met","srtsr","rtjsr","gydtymuj"};
        }
    }

