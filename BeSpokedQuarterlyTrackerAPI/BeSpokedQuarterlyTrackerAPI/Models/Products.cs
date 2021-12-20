using System.ComponentModel.DataAnnotations;

namespace BeSpokedQuarterlyTrackerAPI.Models
{
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Manufacturer { get; set; }
        [MaxLength(50)]
        public string Style { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int QtyOnHand { get; set; }
        public decimal CommissionPct { get; set; }
    }
}