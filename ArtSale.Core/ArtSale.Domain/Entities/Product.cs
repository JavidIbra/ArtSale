using ArtSale.Domain.Entities.Common;

namespace ArtSale.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }
        public bool IsAvailable { get; set; }
        public Guid ProductCode { get; set; }
        public float SalePrice { get; set; }
        public float ActualPrice { get; set; }
        public string? Description { get; set; }
        public List<Review>? Reviews { get; set; }
    }
}
