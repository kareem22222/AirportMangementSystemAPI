using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.API_s.UpdateAPI;
using WebApplication8.Models;
using WebApplication8.DependencyInjections;

namespace WebApplication8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private readonly IUpdateFlightDetails _updateFlightDetails;
        private readonly IUpdateFlightTravelDetailsAPI _flightTravelUpdateAPI;

        public FlightController(IUpdateFlightDetails updateFlightDetails, IUpdateFlightTravelDetailsAPI flightTravelUpdateAPI)
        {
            _updateFlightDetails = updateFlightDetails;
            _flightTravelUpdateAPI = flightTravelUpdateAPI;
        }

        [HttpPut("UpdateFlightDetails/{id}")]
        public IActionResult UpdateFlightDetails(int id, [FromBody] FlightDetails flightDetails)
        {
            if (id != flightDetails.FlightId)
            {
                return BadRequest();
            }

            _updateFlightDetails.PutFlightDetails(flightDetails);

            return NoContent();
        }

        [HttpPut("UpdateFlightTravelInfo/Locations")]
        public IActionResult UpdateFlightTravelInfo(int id, [FromBody] FlightTravelInfo flightTravelInfo)
        {
            if (id != flightTravelInfo.FlightId)
            {
                return BadRequest();
            }

            _flightTravelUpdateAPI.UpdateFlightTravelInfo(id, flightTravelInfo.FlightArrivingLocation, flightTravelInfo.FlightDepartureLocation);

            return NoContent();
        }

        [HttpPut("UpdateFlightTravelInfo/FlightClass")]
        public IActionResult UpdateFlightTravelInfoFlightClass(int id, [FromBody] FlightTravelInfo flightTravelInfo)
        {
            if (id != flightTravelInfo.FlightId)
            {
                return BadRequest();
            }

            _flightTravelUpdateAPI.UpdateFlightTravelClass(id, flightTravelInfo.FlightClass);

            return NoContent();
        }
    }
}