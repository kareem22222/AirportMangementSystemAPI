using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.API_s.ReadAPI;
using WebApplication8.Models;
using WebApplication8.DependencyInjections;

namespace WebApplication8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightReadController : ControllerBase
    {
        private readonly IGetMethodsFlightData _getMethodsFlightData;
        private readonly IGetMethodFlightTravelInfo _getMethodFlightTravelInfo;

        public FlightReadController(IGetMethodsFlightData getMethodsFlightData, IGetMethodFlightTravelInfo getMethodFlightTravelInfo)
        {
            _getMethodsFlightData = getMethodsFlightData;
            _getMethodFlightTravelInfo = getMethodFlightTravelInfo;
        }

        [HttpGet]
        public List<FlightDetails> GetAllFlights()
        {
            List<FlightDetails> flights = _getMethodsFlightData.GetAllFlights();
            return flights;
        }

        [HttpGet("id")]
        public FlightDetails GetById(int id)
        {
            return _getMethodsFlightData.GetFlightById(id);
        }

        [HttpGet("TravelDetails")]
        public List<FlightTravelInfo> GetAllFlight()
        {
            return _getMethodFlightTravelInfo.GetAllFlights();
        }


        [HttpGet("destination")]
        public FlightTravelInfo GetByDestination(string destination)
        {
            return _getMethodFlightTravelInfo.GetFlightByDestination(destination);
        }
    }

}
