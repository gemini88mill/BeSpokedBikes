using System;

namespace BeSpokedQuarterlyTrackerAPI.Models.Dto
{
    public class ReportModels
    {
        
    }

    public class ReportPeramsModel
    {
        public int Qtr { get; set; }
        public int Year { get; set; }
        public int? SalesPersonId { get; set; }
    }

    public class ReportViewModel
    {
        public string SalesPersonName { get; set; }
        public int SalesCount { get; set; }
        public decimal TotalCommissions { get; set; }
        public ReportDetailModel Details { get; set; }
    }

    public class ReportDetailModel
    {
        public int SalesId { get; set; }
        public string ProductName { get; set; }
        public decimal SalePrice { get; set; }
        public decimal CommissionAwarded { get; set; }
    }
}