using ArtSale.Domain.Entities.Common;

namespace ArtSale.Domain.Entities
{
    public class About : BaseEntity
    {
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
