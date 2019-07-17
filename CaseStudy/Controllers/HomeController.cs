using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CaseStudy.Models;
using Microsoft.AspNetCore.Http;

namespace CaseStudy.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Message = HttpContext.Session.GetString("message");
            return View();
        }
    }
}
