using Microsoft.AspNetCore.Mvc;
using CaseStudy.Models;
using System.Collections.Generic;
using CaseStudy.Utils;
using System;
namespace CaseStudy.Controllers
{
    public class BrandController : Controller
    {
        AppDbContext _db;
        public BrandController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index(BrandViewModel vm)
        {
            // only build the catalogue once
            if (HttpContext.Session.Get<List<Brand>>("brands") == null)
            {
                // no session information so let's go to the database
                try
                {
                    BrandModel catModel = new BrandModel(_db);
                    // now load the products
                    List<Brand> brands = catModel.GetAll();
                    HttpContext.Session.Set<List<Brand>>("brands", brands);
                    vm.SetBrands(brands);
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "Catalogue Problem - " + ex.Message;
                }
            }
            else
            {
                // no need to go back to the database as information is already in the session
                vm.SetBrands(HttpContext.Session.Get<List<Brand>>("brands"));
            }
            return View(vm);
        }

        public IActionResult SelectBrand(BrandViewModel vm)
        {
            BrandModel catModel = new BrandModel(_db);
            MenuProductModel menuModel = new MenuProductModel(_db);
            List<Product> items = menuModel.GetAllByBrand(vm.BrandId);
            List<MenuProductViewModel> vms = new List<MenuProductViewModel>();
            if (items.Count > 0)
            {
                foreach (Product item in items)
                {
                    MenuProductViewModel mvm = new MenuProductViewModel();
                    mvm.Qty = 0;
                    mvm.BrandId = item.BrandId;
                    mvm.BrandName = catModel.GetName(item.BrandId);
                    mvm.Description = item.Description;
                    mvm.Id = item.Id;
                    mvm.PRO = item.ProductName;
                    mvm.GRA = item.GraphicName;
                    mvm.COS = item.CostPrice;
                    mvm.MSRP = item.MSRP;
                    mvm.QH = item.QtyOnHand;
                    mvm.QB = item.QtyOnBackOrder;
                    vms.Add(mvm);
                }
                MenuProductViewModel[] myMenu = vms.ToArray();
                HttpContext.Session.Set<MenuProductViewModel[]>("menu", myMenu);
            }
            vm.SetBrands(HttpContext.Session.Get<List<Brand>>("brands"));
            return View("Index", vm); // need the original Index View here
        }

        public ActionResult SelectItem(BrandViewModel vm)
        {
            Dictionary<int, object> tray;
            if (HttpContext.Session.Get<Dictionary<int, Object>>("tray") == null)
            {
                tray = new Dictionary<int, object>();
            }
            else
            {
                tray = HttpContext.Session.Get<Dictionary<int, object>>("tray");
            }
            MenuProductViewModel[] menu = HttpContext.Session.Get<MenuProductViewModel[]>("menu");
            String retMsg = "";
            foreach (MenuProductViewModel item in menu)
            {
                if (item.Id == vm.Id)
                {
                    if (vm.Qty > 0) // update only selected item
                    {
                        item.Qty = vm.Qty;
                        retMsg = vm.Qty + " - item(s) Added!";
                        tray[item.Id] = item;
                    }
                    else
                    {
                        item.Qty = 0;
                        tray.Remove(item.Id);
                        retMsg = "item(s) Removed!";
                    }
                    vm.BrandId = item.BrandId;
                    break;
                }
            }
            ViewBag.AddMessage = retMsg;
            HttpContext.Session.Set<Dictionary<int, Object>>("tray", tray);
            vm.SetBrands(HttpContext.Session.Get<List<Brand>>("brands"));
            return View("Index", vm);
        }
    }
}