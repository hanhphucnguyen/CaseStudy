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
                MenuProductModel itemModel = new MenuProductModel(_db);
                vm.Products = itemModel.GetAllByBrand(vm.Id);
            }
            return View(vm);
        }
    }
}