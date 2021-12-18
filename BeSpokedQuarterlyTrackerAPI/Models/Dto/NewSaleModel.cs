using System;

namespace BeSpokedQuarterlyTrackerAPI.Models.Dto
{
    public class NewSaleModel
    {
        public int CustomerId { get; set; }
        public int SalesPersonId { get; set; }
        public int ProductId { get; set; }
    }

    public class DisplaySalesModel
    {
        public int SalesId { get; set; }
        public string CustomerName { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal Price { get; set; }
        public string SalesPersonName { get; set; }
        public decimal Commission { get; set; }
    }
}