namespace BeSpokedQuarterlyTrackerAPI.Models.Dto
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        // still haven't come up with a good use for a customer startdate within the context of this project, omitting for 
        // data model now. 
    }
}