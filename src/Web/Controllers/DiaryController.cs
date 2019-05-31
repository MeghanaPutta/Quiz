using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace dotnet_mvc_sample.Controllers
{
    public class DiaryController : Controller
    {
        public IActionResult Textmethod()
        {
            return Content("This is Textmethod");
        }

        public IActionResult Jsonmethod()
        {
            return Json(new { name = "JSON", description = "This is controller2" });
        }

        public IActionResult Htmlmethod()
        {
            return Content("<html> <body> <h1> This is Htmlmethod </h1> </body> </html>","text/html");
        }
        public IActionResult Quizmethod()
        {


            return View();


        }

        public IActionResult Viewmethod()
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
