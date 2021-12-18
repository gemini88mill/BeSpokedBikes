namespace BeSpokedQuarterlyTrackerAPI.Models.Dto
{
    public class ProductDto
    {
        
    }

    /// <summary>
    /// Product Update Model - future ask, which portions of the model are suitable for updating, if we had an entire model
    /// able to be updated, then the question becomes what stops someone from being able to change the entire products table
    /// to whatever they want?
    /// </summary>
    public class ProductUpdateModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Style { get; set; }
        public decimal? PurchasePrice { get; set; }
        public decimal? SalePrice { get; set; }
        public int? QtyOnHand { get; set; }
        public decimal? CommissionPct { get; set; }
    }
}