using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Multiple_Implementations_Of_The_Same_Interface.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Multiple_Implementations_Of_The_Same_Interface.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IEnumerable<ICrud> crud;
        public HomeController(ILogger<HomeController> logger, IEnumerable<ICrud> crud)
        {
            _logger = logger;
            this.crud = crud;
            
        }

        public IActionResult Index()
        {
            var result = crud.SingleOrDefault(s => s.GetType() == typeof(MSS));
            result.Update();
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
