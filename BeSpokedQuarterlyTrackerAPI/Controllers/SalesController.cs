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
        [HttpGet]
        public IActionResult GetSales()
        {
            return Ok(new BeSpokeContext().Sales);
        }

        [HttpPost("NewSale")]
        public IActionResult CreateSale(NewSaleModel nsm)
        {
            //get context
            var context = new BeSpokeContext();

            var customers = context.Customers.FirstOrDefault(x => x.CustomerId == nsm.CustomerId);
            var salesperson = context.SalesPersons.FirstOrDefault(x => x.SalespersonId == nsm.SalesPersonId);
            var product = context.Products.FirstOrDefault(x => x.ProductId == nsm.ProductId);
            
            new BeSpokeContext().Sales.Add(new Sales
            {
                Customer = customers,
                Product = product,
                SalesPerson = salesperson,
                SalesDate = DateTime.Now,
                
            });

            return Ok();
        }
    }
}