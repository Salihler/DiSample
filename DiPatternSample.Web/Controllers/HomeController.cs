using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DiPatternSample.Web.Models;

namespace DiPatternSample.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITransientDateService _TransientDateService;
        public HomeController(ITransientDateService TransientDateService)
        {
            _TransientDateService = TransientDateService;
        }

        public IActionResult Index([FromServices]ITransientDateService TransientDateService)
        {
            ViewBag.time1 = _TransientDateService.GetDateTime.TimeOfDay.ToString();
            ViewBag.time2 = TransientDateService.GetDateTime.TimeOfDay.ToString();
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
