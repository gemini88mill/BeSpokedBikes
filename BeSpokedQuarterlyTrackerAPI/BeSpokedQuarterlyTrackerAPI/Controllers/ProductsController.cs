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
        /// Updates the product object, I would imagine that there should be some restrictions, or adds instead of updates.
        /// however, I don't have enough information to restrict at the moment, user could be requesting this vagueness, for
        /// something that I currently don't have access to. 
        /// </summary>
        /// <param name="pum">Dto for production update</param>
        /// <returns>200 ok result on completion of add, returns bad request on failure. </returns>
        [HttpPost("Update")]
        public IActionResult UpdateProduct(ProductUpdateModel pum)
        {
            var result = _context.Products.FirstOrDefault(x => x.ProductId == pum.ProductId);

            if (result == null) return BadRequest();

            result.Manufacturer = pum.Manufacturer ?? result.Manufacturer;
            result.Name = pum.Name ?? result.Name;
            result.Style = pum.Style ?? result.Style;
            result.CommissionPct = pum.CommissionPct ?? result.CommissionPct;
            result.PurchasePrice = pum.PurchasePrice ?? result.PurchasePrice;
            result.SalePrice = pum.SalePrice ?? result.SalePrice;
            result.QtyOnHand = pum.QtyOnHand ?? result.QtyOnHand;

            return Ok();
        }
    }
}