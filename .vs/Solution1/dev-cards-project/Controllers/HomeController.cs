using dev_cards_project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace dev_cards_project.Controllers
{
    public class HomeController : Controller
    {
      public IActionResult projects()
        {
            return View();
        }

        public IActionResult Index() { 
             News n = new News()
            {
                description = " i am description", title = "i am title", newsid = 100
            };
       
            return View(n);
        }

        public IActionResult news()
        {
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
