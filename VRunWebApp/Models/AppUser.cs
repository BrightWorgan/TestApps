using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace VRunWebApp.Models
{
    public class AppUser //: IdentityUser
    {
        public string Id { get; set; }

        public double? AveragPace { get; set; }

        public int? AverageDistance { get; set; }

        public bool RunningWithDog { get; set; }

        [ForeignKey("Address")]
        public int? AddressID { get; set; }
        public Address? Address { get; set; }
        public ICollection<RunningClub> Clubs { get; set; }
        public ICollection<RaceCourse> Races { get; set; }



    }
}
