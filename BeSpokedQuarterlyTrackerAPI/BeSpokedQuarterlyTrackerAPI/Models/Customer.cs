using System;
using System.ComponentModel.DataAnnotations;

namespace BeSpokedQuarterlyTrackerAPI.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [MaxLength(13)]
        public string Phone { get; set; }
        public DateTime StartDate { get; set; } //what does a customer need a start date for? Date of firstSale? 
    }
}