using System;

namespace BeSpokedQuarterlyTrackerAPI.Models
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public Products Product { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal DiscountPct { get; set; }
        public string DiscountName { get; set; }
    }
}