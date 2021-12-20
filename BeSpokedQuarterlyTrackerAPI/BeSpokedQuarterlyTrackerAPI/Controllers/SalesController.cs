using System;
using System.Collections.Generic;
using System.Linq;
using BeSpokedQuarterlyTrackerAPI.Models;
using BeSpokedQuarterlyTrackerAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BeSpokedQuarterlyTrackerAPI.Controllers
{
    /// <summary>
    /// Sales Controller - all actions related to the sales data object go here. 
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class SalesController : ControllerBase
    {
        // DI Component from startup.cs
        private BespokeDbContext _context = new BespokeDbContext();
        
        /// <summary>
        /// Gets all sales uses Dto model to display relevant data. 
        /// </summary>
        /// <returns>Dto representation of Sales. </returns>
        [HttpGet]
        public IActionResult GetSales()
        {
            var allSales = _context.Sales;

            var displaySalesList = allSales.Select(item => new DisplaySalesModel
                {
                    SalesPersonName = item.SalesPerson.FirstName.Trim() + " " + item.SalesPerson.LastName.Trim(),
                    SalesId = item.SalesId,
                    SaleDate = item.SalesDate,
                    Price = item.SalePrice,
                    Commission = item.CommissionAwarded,
                    CustomerName = item.Customer.FirstName.Trim() + " " + item.Customer.LastName.Trim(),
                    ProductName = item.Product.Manufacturer.Trim() + " - " + item.Product.Name.Trim()
                })
                .ToList();

            return Ok(displaySalesList);
        }

        /// <summary>
        /// Creates a new sale, a new sale is dependent on the Product, Customer and SalesPersons to be available. 
        /// </summary>
        /// <param name="nsm">New Sale Model Object. ID's of respective Data Object.</param>
        /// <returns>Ok result on success</returns>
        [HttpPost("NewSale")]
        public IActionResult CreateSale(NewSaleModel nsm)
        {

            var customers = _context.Customers.FirstOrDefault(x => x.CustomerId == nsm.CustomerId);
            var salesperson = _context.SalesPersons.FirstOrDefault(x => x.SalespersonId == nsm.SalesPersonId);
            var product = _context.Products.FirstOrDefault(x => x.ProductId == nsm.ProductId);

            if (product == null) return BadRequest(new
            {
                response = "product not found"
            });
            
            _context.Sales.Add(new Sales
            {
                Customer = customers,
                Product = product,
                SalesPerson = salesperson,
                SalesDate = DateTime.Now,
                SalePrice = nsm.SalePrice,
                CommissionAwarded = nsm.CommissionAwarded
            });
                
            product.QtyOnHand--;

            _context.SaveChanges();

            return Ok(new
            {
                Response = "Success"
            });
        }
    }
}