using System.Collections.Generic;
namespace CaseStudy.Models
{
    public class MenuProductViewModel
    {
        public string BrandName { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
