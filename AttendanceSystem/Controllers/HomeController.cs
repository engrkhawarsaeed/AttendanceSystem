using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AttendanceSystem.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
                
        }
        public IActionResult Index()
        {
            ViewBag.Title = "Khawar";
            ViewData["Title"] = "khawar";


            TempData["Title"] = "khawar";
            return View();
        }

        public IActionResult Detail(int abc)
        {
            return View();
        }
    }
}
