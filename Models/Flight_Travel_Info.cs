using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication8.Models
{
    public class FlightTravelInfo
    {
        [Key] public int FlightTravelId { get; set; }                     
        public string FlightArrivingLocation { get; set; }
        public string FlightDepartureLocation { get; set; }
        public string FlightClass { get; set; }

        [ForeignKey("FlightId")] public int FlightId { get; set; }
        public FlightDetails Flight { get; set; }

    }
}
    