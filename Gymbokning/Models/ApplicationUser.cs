using Microsoft.AspNetCore.Identity;

namespace Gymbokning.Models
{
    public class ApplicationUser : IdentityUser
    {
        //public int Id { get; set; }

        //navigational property
        public ICollection<ApplicationUserGymClass> AttendedGymClasses { get; set; } = default!;

    }
}
