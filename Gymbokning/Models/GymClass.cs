namespace Gymbokning.Models
{
    public class GymClass
    {
        public int GymClassId { get; set; }
        public string Name { get; set; } = string.Empty;

        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public DateTime EndTime { get { return StartTime + Duration; } }
        public String Description { get; set; } = String.Empty;


        //navigational property
        public ICollection<ApplicationUserGymClass> AttendingMembers { get; set; } 
    }
}
