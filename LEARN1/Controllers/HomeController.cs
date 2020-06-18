using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LEARN1.Models;
using LEARN1.Application.Implementation;
using LEARN1.Application.Interfaces;

namespace LEARN1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IClewService _clewService;

        public HomeController(ILogger<HomeController> logger, IClewService clewService)
        {
            _logger = logger;
            _clewService = clewService;
        }

        public IActionResult Index()
        {
            var data = _clewService.GetAll();
            return View();
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
