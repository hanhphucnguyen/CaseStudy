using System.Collections.Generic;
namespace CaseStudy.Models
{
    public class MenuProductViewModel
    {
        public string BrandName { get; set; }
        public int BrandId { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public int Qty { get; set; }
        public string PRO { get; set; }
        public string GRA { get; set; }
        public float COS { get; set; }
        public float MSRP { get; set; }
        public int QH { get; set; }
        public int QB { get; set; }
        public string BRAND { get; set; }
    }
}
