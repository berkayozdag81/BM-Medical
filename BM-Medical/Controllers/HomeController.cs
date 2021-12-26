using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BM_Medical_Resource;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using BM_Medical_DTO.Models;

namespace BM_Medical.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

       

        [HttpPost]
        public IActionResult SetLanguage(Lang modellang)
        {
            Lang Languege = new Lang();
            if (modellang is null)
            {
                Languege.selectedLanguage = "eng";
                Languege.Url = "https://localhost:44351/Home";
            }
            else
            {
                Languege.selectedLanguage = modellang.selectedLanguage;
                Languege.Url = "https://localhost:44351/Home";

            }
            HttpContext.Session.SetString("language", Languege.selectedLanguage);
            Labels.Culture = new System.Globalization.CultureInfo(Languege.selectedLanguage);
            if (Languege.selectedLanguage == "tur")
            {

                Labels.Culture = null;
            }
            return View("/Home/Index");
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
