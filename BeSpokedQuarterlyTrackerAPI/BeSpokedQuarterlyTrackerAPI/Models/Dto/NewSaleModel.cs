using System;

namespace BeSpokedQuarterlyTrackerAPI.Models.Dto
{
    public class NewSaleModel
    {
        public int CustomerId { get; set; }
        public int SalesPersonId { get; set; }
        public int ProductId { get; set; }

        public decimal SalePrice { get; set; }
        public decimal CommissionAwarded { get; set; }
    }

    public class DisplaySalesModel
    {
        public int SalesId { get; set; }
        public string CustomerName { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal Price { get; set; }
        public string SalesPersonName { get; set; }
        public decimal Commission { get; set; }

        public string ProductName { get; set; }
    }
}