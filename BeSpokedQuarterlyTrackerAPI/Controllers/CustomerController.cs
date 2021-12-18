using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BeSpokedQuarterlyTrackerAPI.Models;
using BeSpokedQuarterlyTrackerAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BeSpokedQuarterlyTrackerAPI.Controllers
{
    /// <summary>
    /// Customer controller - All customer Data object retrival goes here. 
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        //DI 
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
            var customers = _context.Customers.Select(item => new CustomerDto
            {
                Name = item.FirstName.Trim() + " " + item.LastName.Trim(), 
                Address = item.Address.Trim(),
                Phone = item.Phone.Trim(), 
                CustomerId = item.CustomerId
            }).ToList();

            return Ok(customers);
        }
    }
}