using System;
using System.Linq;
using BeSpokedQuarterlyTrackerAPI.Models;
using BeSpokedQuarterlyTrackerAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BeSpokedQuarterlyTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private BeSpokeContext _context { get; }

        public ProductsController(BeSpokeContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Display a list of products
        /// </summary>
        /// <returns>List of products</returns>
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(_context.Products);
        }

        /// <summary>
        /// Updates the product object, check to see if user entered information is duplicated and rejects. 
        /// </summary>
        /// <param name="pum">Dto for production update</param>
        /// <returns>200 ok result on completion of add, returns bad request on failure. </returns>
        [HttpPost("Update")]
        public IActionResult UpdateProduct(ProductUpdateModel pum)
        {
            var result = _context.Products.FirstOrDefault(x => x.ProductId == pum.ProductId);
            var products = _context.Products;

            if (result == null || products.Any(x =>
                    x.Manufacturer.Trim().Equals(pum.Manufacturer.Trim(), StringComparison.InvariantCultureIgnoreCase) &&
                    x.Manufacturer.Trim().Equals(pum.Name.Trim(), StringComparison.InvariantCultureIgnoreCase)))
            {
                return BadRequest();
            }

            result.Manufacturer = pum.Manufacturer ?? result.Manufacturer;
            result.Name = pum.Name ?? result.Name;
            result.Style = pum.Style ?? result.Style;
            result.CommissionPct = pum.CommissionPct ?? result.CommissionPct;
            result.PurchasePrice = pum.PurchasePrice ?? result.PurchasePrice;
            result.SalePrice = pum.SalePrice ?? result.SalePrice;
            result.QtyOnHand = pum.QtyOnHand ?? result.QtyOnHand;

            return Ok();
        }

        /// <summary>
        /// Product Add, controller method to add new products to inventory, includes a check for product duplicates.
        /// Note: the requirements do not state for this to be added to the system. It is possible that a future update
        /// might require this to be needed but the current iteration does not call for it. not including on UI for now. 
        /// </summary>
        /// <param name="pam">Dto for Production Add</param>
        /// <returns>OK result on success, Bad Request on failure</returns>
        [HttpPost("Add")]
        public IActionResult AddProduct(ProductAddModel pam)
        {
            //get current list of products
            var products = _context.Products;
            // product is considered duplicate if the product name is equal to the manufactuer and name fields
            if (products.Any(x =>
                    x.Manufacturer.Trim().Equals(pam.Manufacturer.Trim(), StringComparison.InvariantCultureIgnoreCase) &&
                    x.Manufacturer.Trim().Equals(pam.Name.Trim(), StringComparison.InvariantCultureIgnoreCase)))
            {
                return BadRequest(new
                {
                    response = "Duplicate Product Found"
                });
            }
            
            _context.Products.Add(new Products
            {
                Name = pam.Name,
                Manufacturer = pam.Manufacturer,
                Style = pam.Style,
                CommissionPct = pam.CommissionPct,
                ProductId = _context.Products.Count + 1,
                PurchasePrice = pam.PurchasePrice,
                SalePrice = pam.SalePrice,
                QtyOnHand = pam.QtyOnHand
            });

            return Ok(new
            {
                response = "Success"
            });
        }
    }
}