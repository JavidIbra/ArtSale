using ArtSale.Domain.Entities.Common;

namespace ArtSale.Domain.Entities
{
    public class Review : BaseEntity
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Comment { get; set; }
        public int Rating { get; set; }
        public virtual Product Product { get; set; }
        public int ProductId { get; set; }
    }
}
