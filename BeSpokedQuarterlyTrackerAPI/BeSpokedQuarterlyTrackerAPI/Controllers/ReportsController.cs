using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BeSpokedQuarterlyTrackerAPI.Common;
using BeSpokedQuarterlyTrackerAPI.Models;
using BeSpokedQuarterlyTrackerAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BeSpokedQuarterlyTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReportsController : ControllerBase
    {
        //DI 
        private BespokeDbContext _context = new BespokeDbContext();

        /// <summary>
        /// Quarterly Summary report controller - gets the sales information and groups the data by salesperson. 
        /// </summary>
        /// <param name="rpm"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GetQuarterlyReport(ReportPeramsModel rpm)
        {
            var dateRange = DateMath.GetDateRange(rpm.Qtr, rpm.Year);
            
            List<Sales> salesList = new List<Sales>();
            salesList.AddRange(rpm.SalesPersonId != null
                ? _context.Sales.Where(x =>
                    x.SalesPerson.SalespersonId == rpm.SalesPersonId && x.SalesDate <= dateRange.EndDate &&
                    x.SalesDate >= dateRange.StartDate).ToList()
                : _context.Sales.Where(x =>
                    x.SalesDate <= dateRange.EndDate && x.SalesDate >= dateRange.StartDate).ToList());

            return Ok(salesList.Select(x => new 
            {
                SalesPersonName = x.SalesPerson.FirstName.Trim() + " " + x.SalesPerson.LastName.Trim(),
                SalesPersonId = x.SalesPerson.SalespersonId,
                SalesId = x.SalesId,
                SaleDate = x.SalesDate,
                Price = x.SalePrice,
                Commission = x.CommissionAwarded,
                CustomerName = x.Customer.FirstName.Trim() + " " + x.Customer.LastName.Trim()
            }).GroupBy(x => x.SalesPersonId).Select(y => new
            {
                y.Key,
                SalesCount = y.Count(),
                SalesPersonName = y.Min(x => x.SalesPersonName),
                CommissionTotal = y.Sum(x => x.Commission),
                TotalSales = y.Sum(x => x.Price)
            }));
        }
    }
}