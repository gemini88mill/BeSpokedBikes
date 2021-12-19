using System;

namespace BeSpokedQuarterlyTrackerAPI.Models.Dto
{
    public class SalespersonDTO
    {
        
    }

    public class SalesPersonModelView
    {
        public int SalesPersonId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Manager { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

    public class UpdateSalesPersonModel
    {
        public int SalesPersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Manager { get; set; }
    }
}