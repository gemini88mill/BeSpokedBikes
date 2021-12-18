using BeSpokedQuarterlyTrackerAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace BeSpokedQuarterlyTrackerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalesPersonController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSalesPersons()
        {
            return Ok(new BeSpokeContext().SalesPersons);
        }
    }
}