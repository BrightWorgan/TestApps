namespace VRunWebApp.Models
{
    public class AppUser //: IdentityUser
    {
        public int Id { get; set; }

        public int? AveragPace { get; set; }

        public int? AverageDistance { get; set; }

        public bool RunningWithDog { get; set; }

        public Address? Address { get; set; }
    }
}
