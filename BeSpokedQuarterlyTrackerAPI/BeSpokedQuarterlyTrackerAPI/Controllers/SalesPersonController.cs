using System.Linq;
using BeSpokedQuarterlyTrackerAPI.Models;
using BeSpokedQuarterlyTrackerAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BeSpokedQuarterlyTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalesPersonController : ControllerBase
    {
        private BeSpokeContext _context { get; set; }

        public SalesPersonController(BeSpokeContext context)
        {
            _context = context;
        }
        
        /// <summary>
        /// Display a list of salespersons
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetSalesPersons()
        {
            return Ok(_context.SalesPersons);
        }

        /// <summary>
        /// Update a salesperson.
        /// Assumption: as a sales tracking application, start date and termination date should not be defined in this project
        /// and something to update. Start Date is set and Termination Date should not be defined in a tracking app. 
        /// </summary>
        /// <param name="uspm">update model for salesperson object</param>
        /// <returns>Ok result on successful update, 400 on null response from salesperson Data object</returns>
        [HttpPost("Update")]
        public IActionResult UpdateSalesPerson(UpdateSalesPersonModel uspm)
        {
            var result = _context.SalesPersons.FirstOrDefault(x => x.SalespersonId == uspm.SalesPersonId);

            if (result == null) return BadRequest();
            
            result.Address = uspm.Address ?? result.Address;
            result.Manager = uspm.Manager ?? result.Manager;
            result.Phone = uspm.Phone ?? result.Phone;
            result.FirstName = uspm.FirstName ?? result.FirstName;
            result.LastName = uspm.LastName ?? result.LastName;

            return Ok();
        }
    }
}