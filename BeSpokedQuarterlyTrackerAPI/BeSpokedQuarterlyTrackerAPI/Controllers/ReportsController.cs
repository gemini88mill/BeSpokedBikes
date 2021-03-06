using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BeSpokedQuarterlyTrackerAPI.Common;
using BeSpokedQuarterlyTrackerAPI.Models;
using BeSpokedQuarterlyTrackerAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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

            var salesList = _context.Sales
                .Include(x => x.Customer)
                .Include(x => x.Product)
                .Include(x => x.SalesPerson)
                .ToList();

            if (rpm.SalesPersonId != null)
            {
                salesList = salesList.Where(x => x.SalesPerson.SalespersonId == rpm.SalesPersonId).ToList();
            }

            salesList = salesList.Where(x => x.SalesDate >= dateRange.StartDate && x.SalesDate <= dateRange.EndDate)
                .ToList();
            

            return Ok(salesList.Select(x => new
            {
                SalesPersonName = x.SalesPerson.FirstName.Trim() + " " + x.SalesPerson.LastName.Trim(),
                SalesPersonId = x.SalesPerson.SalespersonId,
                SalesId = x.SalesId,
                SaleDate = x.SalesDate,
                Price = x.SalePrice,
                Commission = x.CommissionAwarded,
                // CustomerName = x.Customer.FirstName.Trim() + " " + x.Customer.LastName.Trim()
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