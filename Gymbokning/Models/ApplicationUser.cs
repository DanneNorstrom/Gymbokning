using Microsoft.AspNetCore.Identity;

namespace Gymbokning.Models
{
    public class ApplicationUser : IdentityUser
    {
        //navigational property
        public ICollection<ApplicationUserGymClass> AttendedGymClasses { get; set; }

        public void testc()
        {
            this.Id;
        }

    }
}
