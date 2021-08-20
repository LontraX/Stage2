using InteractiveResume.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace InteractiveResume.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDataContext _ctx;

        public HomeController(ILogger<HomeController> logger, AppDataContext context)
        {
            _logger = logger;
            _ctx = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public  IActionResult Index(Contact model)
        {
            if (!ModelState.IsValid)
            {
                
            }

            if (model == null)
            {
                //await _ctx.contacts.AddAsync(model);
                TempData["Message"] = "MESSAGE NOT SENT,PLEASE FILL ALL FIELDS CORRECTLY";
                return View();
            }
            else
            {
                TempData["Message"] = "THANK YOU FOR CONTACTING ME, I WILL GET IN TOUCH WITH YOU";
                return RedirectToAction("Index","Home","formarea");
            }

        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
