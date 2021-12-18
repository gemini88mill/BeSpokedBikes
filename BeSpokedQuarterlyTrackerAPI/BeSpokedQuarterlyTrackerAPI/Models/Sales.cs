using System;

namespace BeSpokedQuarterlyTrackerAPI.Models
{
    // Note if the Product changes, the commission could be effected? 
    public class Sales
    {
        public int SalesId { get; set; }
        public Products Product { get; set; }
        public SalesPerson SalesPerson { get; set; }
        public Customer Customer { get; set; }
        public DateTime SalesDate { get; set; }

        public decimal SalePrice { get; set; }
        public decimal CommissionAwarded { get; set; }
        
    }
}