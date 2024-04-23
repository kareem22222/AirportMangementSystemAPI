using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.API_s.CreateAPI;
using WebApplication8.Models;
using WebApplication8.DependencyInjections;

namespace WebApplication8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightPostController : ControllerBase
    {
        public IPost_FlightData Post_FlightData { get; }
        public IPost_FlightTravelData Post_FlightTravelData { get; }
        public FlightPostController(IPost_FlightData post_FlightData, IPost_FlightTravelData post_FlightTravelData)
        {
            Post_FlightData = post_FlightData;
            Post_FlightTravelData = post_FlightTravelData;
        }

        [HttpPost("FlightDetails")]
        public IActionResult AddFlightDetails(FlightDetails flightDetails)
        {
            Post_FlightData.AddFlightDetails(flightDetails);
            return Ok(flightDetails);
        }

        [HttpPost("FlightTravelDetails")]
        public IActionResult AddFlightTravelInfo(FlightTravelInfo flightTravelInfo)
        {
            Post_FlightTravelData.AddFlightTravelInfo(flightTravelInfo);
            return Ok(flightTravelInfo);
        }

    }
}
