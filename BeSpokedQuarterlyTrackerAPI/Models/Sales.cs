using System;

namespace BeSpokedQuarterlyTrackerAPI.Models
{
    public class Sales
    {
        public int SalesId { get; set; }
        public Products Product { get; set; }
        public SalesPerson SalesPerson { get; set; }
        public Customer Customer { get; set; }
        public DateTime SalesDate { get; set; }
    }
}