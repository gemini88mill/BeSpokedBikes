using System.Linq;
using BeSpokedQuarterlyTrackerAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeSpokedQuarterlyTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiscountController : ControllerBase
    {
        // DI Component from startup.cs
        private BespokeDbContext _context { get; set; }
        
        public DiscountController(BespokeDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDiscounts()
        {
            return Ok(_context.Discounts.Select(x => new
            {
                x.DiscountId,
                x.DiscountPct,
                x.BeginDate,
                x.EndDate,
                x.Product.ProductId,
                x.DiscountName
            }));
        }
    }
}