using System;

namespace BeSpokedQuarterlyTrackerAPI.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime StartDate { get; set; } //what does a customer need a start date for? Date of firstSale? 
    }
}