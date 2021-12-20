using System;
using System.ComponentModel.DataAnnotations;

namespace BeSpokedQuarterlyTrackerAPI.Models
{
    public class Discount
    {
        [Key]
        public int DiscountId { get; set; }
        public Products Product { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal DiscountPct { get; set; }
        [MaxLength(50)]
        public string DiscountName { get; set; }
    }
}