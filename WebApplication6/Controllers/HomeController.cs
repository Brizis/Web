using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Table()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }

        public IActionResult Error(Error error)
        {
            return View(error);
        }
    }
}
