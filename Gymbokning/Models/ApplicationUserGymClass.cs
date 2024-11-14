using Gymbokning.Models;

namespace Gymbokning
{
    public class ApplicationUserGymClass
    {

        //Convention 4 Add foreign Key

        public int ApplicationUserId { get; set; }
        
        public int GymClassId { get; set; }

        //Navigational properties

        //public GymClass GymClass { get; set; } = default!;

        //public ApplicationUser ApplicationUser { get; set; } = default!;
    }
}