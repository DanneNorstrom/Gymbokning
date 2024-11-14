namespace Gymbokning.Models
{
    public class GymClass
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime EndTime { get { return StartTime + Duration; } }
        public string Description { get; set; } = string.Empty;


        //navigational property
        //public ICollection<ApplicationUserGymClass> AttendingMembers { get; set; } = default!;
    }
}
