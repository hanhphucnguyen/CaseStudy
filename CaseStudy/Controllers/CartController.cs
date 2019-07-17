using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using CaseStudy.Utils;
namespace CaseStudy.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult ClearCart() // clear out current tray
        {
            HttpContext.Session.Remove("cart");
            HttpContext.Session.Set<String>("message", "Cart Cleared");
            return Redirect("/Home");
        }
    }
}