using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RazorviewHandson.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RazorviewHandson.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ITOrganizations()
        {
            List<string> organizationList = new List<string>
            {
                "Microsoft www.microsoft.com","CTS www.cognizant.com", "Google", "Amazon","TCS"
            };
            return View(organizationList);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
