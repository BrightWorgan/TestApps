using System.ComponentModel.DataAnnotations;
namespace VRunWebApp.Models
{
    public class Address
    {
        [Key]
        public int ID { get; set; }
        public string EirCode { get; set; }
        public string Town { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
    }
}
                   