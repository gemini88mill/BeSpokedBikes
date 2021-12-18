using System;

namespace BeSpokedQuarterlyTrackerAPI.Models
{
    public class SalesPerson
    {
        public int SalespersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string Manager { get; set; }
    }
}