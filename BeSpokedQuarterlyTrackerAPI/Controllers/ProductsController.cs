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