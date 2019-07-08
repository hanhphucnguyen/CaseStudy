using Microsoft.AspNetCore.Mvc;
using CaseStudy.Models;
namespace CaseStudy.Controllers
{
    public class ProductController : Controller
    {
        AppDbContext _db;
        public ProductController(AppDbContext context)
        {
            _db = context;
        }
        public IActionResult Index(BrandViewModel brand)
        {
            MenuProductModel model = new MenuProductModel(_db);
            MenuProductViewModel viewModel = new MenuProductViewModel();
            viewModel.Products = model.GetAllByBrand(brand.Id);
            viewModel.BrandName = model.GetBrand(brand.Id).Name;
            return View(viewModel);
        }
    }
}