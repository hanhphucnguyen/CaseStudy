using System.Collections.Generic;
using System.Linq;
namespace CaseStudy.Models
{
    public class MenuProductModel
    {
        private AppDbContext _db;
        public MenuProductModel(AppDbContext context)
        {
            _db = context;
        }
        public List<Product> GetAll()
        {
            return _db.Products.ToList();
        }
        public List<Product> GetAllByBrand(int id)
        {
            return _db.Products.Where(item => item.Brand.Id == id).ToList();
        }
        public Brand GetBrand(int id)
        {
            return _db.Brands.FirstOrDefault(cat => cat.Id == id);
        }
    }
}