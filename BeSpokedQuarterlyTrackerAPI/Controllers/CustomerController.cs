using System.Threading.Tasks;
using BeSpokedQuarterlyTrackerAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeSpokedQuarterlyTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private BeSpokeContext _context { get; set; }
        
        public CustomerController(BeSpokeContext context)
        {
            _context = context;
        }
        
        /// <summary>
        /// Gets the complete list of customers. 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetCustomers()
        {
            return Ok(_context.Customers);
        }
    }
}