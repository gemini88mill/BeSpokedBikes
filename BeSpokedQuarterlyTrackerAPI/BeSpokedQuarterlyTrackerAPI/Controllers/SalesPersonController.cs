using System;
using System.Collections.Generic;
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
        private BespokeDbContext _context = new BespokeDbContext();
        
        /// <summary>
        /// Display a list of salespersons
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetSalesPersons()
        {
            var salespersonView = _context.SalesPersons.Select(item => new SalesPersonModelView
                {
                    Name = item.FirstName.Trim() + " " + item.LastName.Trim(),
                    Address = item.Address,
                    Manager = item.Manager,
                    Phone = item.Phone,
                    SalesPersonId = item.SalespersonId,
                    StartDate = item.StartDate,
                    EndDate = item.TerminationDate 
                })
                .ToList();

            return Ok(salespersonView);
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
            var salesPeople = _context.SalesPersons.Where(x => result.SalespersonId != x.SalespersonId);
            
            if (result == null || salesPeople.Any(x =>
                    x.FirstName.Trim().Equals(uspm.FirstName.Trim(), StringComparison.InvariantCultureIgnoreCase) &&
                    x.LastName.Trim().Equals(uspm.LastName, StringComparison.InvariantCultureIgnoreCase)))
            {
                return BadRequest(new
                {
                    response = result == null ? "Salesperson not found" : "Duplicate Name Found"
                });
            }
            
            
            
            result.Address = uspm.Address ?? result.Address;
            result.Manager = uspm.Manager ?? result.Manager;
            result.Phone = uspm.Phone ?? result.Phone;
            result.FirstName = uspm.FirstName ?? result.FirstName;
            result.LastName = uspm.LastName ?? result.LastName;

            _context.SaveChanges();

            return Ok(new
            {
                response = "success"
            });
        }
    }
}