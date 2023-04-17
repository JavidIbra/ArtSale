using Microsoft.AspNetCore.Identity;

namespace ArtSale.Domain.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string? FullName { get; set; }
        public string? Photo { get; set; }   
        public bool IsActive { get; set; }   
    }
}
