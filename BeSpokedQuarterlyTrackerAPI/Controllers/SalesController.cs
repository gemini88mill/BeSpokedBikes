using System;
using System.Linq;
using BeSpokedQuarterlyTrackerAPI.Models;
using BeSpokedQuarterlyTrackerAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BeSpokedQuarterlyTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalesController : ControllerBase
    {
        private BeSpokeContext _context { get; }

        public SalesController(BeSpokeContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IActionResult GetSales()
        {
            return Ok(_context.Sales);
        }

        [HttpPost("NewSale")]
        public IActionResult CreateSale(NewSaleModel nsm)
        {

            var customers = _context.Customers.FirstOrDefault(x => x.CustomerId == nsm.CustomerId);
            var salesperson = _context.SalesPersons.FirstOrDefault(x => x.SalespersonId == nsm.SalesPersonId);
            var product = _context.Products.FirstOrDefault(x => x.ProductId == nsm.ProductId);
            var salesCount = _context.Sales.Count + 1;
            
            _context.Sales.Add(new Sales
            {
                Customer = customers,
                Product = product,
                SalesPerson = salesperson,
                SalesDate = DateTime.Now,
                SalesId = salesCount
            });

            return Ok();
        }
    }
}