using System;
using System.ComponentModel.DataAnnotations;

namespace BeSpokedQuarterlyTrackerAPI.Models
{
    public class SalesPerson
    {
        [Key]
        public int SalespersonId { get; set; }
        [MaxLength(50)]
        public string FirstName { get; set; }
        [MaxLength(50)]
        public string LastName { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [MaxLength(17)]
        public string Phone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        [MaxLength(50)]
        public string Manager { get; set; }
    }
}