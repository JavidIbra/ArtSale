using Microsoft.AspNetCore.Identity;

namespace ArtSale.Domain.Entities
{
    public class AppRole : IdentityRole<int>
    {
        public bool IsActive { get; set; }
    }
}
