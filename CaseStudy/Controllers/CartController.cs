using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using CaseStudy.Utils;
using CaseStudy.Models;
using System.Collections.Generic;

namespace CaseStudy.Controllers
{
    public class CartController : Controller
    {
        AppDbContext _db;
        public CartController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult ClearCart() // clear out current tray
        {
            HttpContext.Session.Remove(SessionVariables.Cart);
            HttpContext.Session.SetString(SessionVariables.Message, "Cart Cleared");
            return Redirect("/Home");
        }
        // Add the cart, pass the session variable info to the db
        public ActionResult AddCart()
        {
            OrderModel model = new OrderModel(_db);
            int retVal = -1;
            string retMessage = "";
            try
            {
                Dictionary<string, object> trayItems = HttpContext.Session.Get<Dictionary<string, object>>(SessionVariables.Cart);
                retVal = model.AddCart(trayItems, HttpContext.Session.Get<ApplicationUser>(SessionVariables.User));
                if (retVal > 0) // Tray Added
                {
                    retMessage = "Cart " + retVal + " Created!";
                }
                else // problem
                {
                    retMessage = "Cart not added, try again later";
                }
            }
            catch (Exception ex) // big problem
            {
                retMessage = "Cart was not created, try again later! - " + ex.Message;
            }
            HttpContext.Session.Remove(SessionVariables.Cart); // clear out current cart once persisted
            HttpContext.Session.SetString(SessionVariables.Message, retMessage);
            return Redirect("/Home");
        }

        [Route("[action]")]
        public IActionResult GetCarts()
        {
            OrderModel model = new OrderModel(_db);
            ApplicationUser user = HttpContext.Session.Get<ApplicationUser>(SessionVariables.User);
            return Ok(model.GetAll(user));
        }
        public IActionResult List()
        {
            // they can't list Trays if they're not logged on
            if (HttpContext.Session.Get<ApplicationUser>(SessionVariables.User) == null)
            {
                return Redirect("/Login");
            }
            return View("List");
        }

        [Route("[action]/{tid:int}")]
        public IActionResult GetOrderDetails(int tid)
        {
            OrderModel model = new OrderModel(_db);
            ApplicationUser user = HttpContext.Session.Get<ApplicationUser>(SessionVariables.User);
            return Ok(model.GetOrderDetails(tid, user.Id));
        }
    }
}