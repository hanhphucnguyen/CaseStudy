using Microsoft.AspNetCore.Mvc;
using CaseStudy.Models;
using CaseStudy.Utils;
using Microsoft.AspNetCore.Http;
namespace CaseStudy.Controllers
{
    public class BranchController : Controller
    {
        AppDbContext _db;
        public BranchController(AppDbContext context)
        {
            _db = context;
        }
        public ActionResult Index()
        {
            if (HttpContext.Session.GetString(SessionVariables.Message) != null)
            {
                ViewBag.Message = HttpContext.Session.GetString(SessionVariables.Message);
            }
            return View();
        }
        [Route("[action]/{lat:double}/{lng:double}")]
        public IActionResult GetStores(float lat, float lng)
        {
            BranchModel model = new BranchModel(_db);
            return Ok(model.GetThreeClosestStores(lat, lng));
        }
    }
}