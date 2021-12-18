namespace BeSpokedQuarterlyTrackerAPI.Models.Dto
{
    public class SalespersonDTO
    {
        
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