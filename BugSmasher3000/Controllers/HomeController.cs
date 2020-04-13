using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BugSmasher3000.Models;
using System.Data;

namespace BugSmasher3000.Controllers
{
    public class HomeController : Controller
    {
        private IEmployee repository;
        public HomeController(IEmployee repo)
        {
            repository = repo;
        }
        private readonly ILogger<HomeController> _logger;
        /*
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        */
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Users()
        {
            
            return View(repository.Employee);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
