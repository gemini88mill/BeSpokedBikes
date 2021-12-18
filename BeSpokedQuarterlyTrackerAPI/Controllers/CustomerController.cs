using System.Threading.Tasks;
using BeSpokedQuarterlyTrackerAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeSpokedQuarterlyTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        /// <summary>
        /// Gets the complete list of customers. 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            return Ok(new BeSpokeContext().Customers);
        }
    }
}