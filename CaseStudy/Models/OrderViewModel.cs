namespace CaseStudy.Models
{
    public class OrderViewModel
    {
        public int Qty { get; set; }
        public string Description { get; set; }
        public string DateCreated { get; set; }
        public string Name { get; set; }
        public decimal MSRP { get; set; }
        public int QtyO { get; set; }
        public int QtyB { get; set; }
        public decimal OrderAmount { get; set; }
    }
}