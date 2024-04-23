using System.ComponentModel.DataAnnotations;

namespace WebApplication8.Models
{
    public class FlightDetails
    {
        [Key]
        public int FlightId { get; set; }
        public string FlightName { get; set; }
        public string FlightModel { get; set; }

    }
}
