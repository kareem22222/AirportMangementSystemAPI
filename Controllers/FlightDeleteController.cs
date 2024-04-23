using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.API_s.DeleteAPI;
using WebApplication8.DependencyInjections;

namespace WebApplication8.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeleteFlightDetailsController : ControllerBase
    {
        private readonly IDeleteFlightDetailsAPI deleteFlightDetailsAPI;

        public DeleteFlightDetailsController(IDeleteFlightDetailsAPI deleteFlightDetailsAPI, IDeleteFlightTravelDetailsAPI deleteFlightTravelDetailsAPI)
        {
            this.deleteFlightDetailsAPI = deleteFlightDetailsAPI;
            DeleteFlightTravelDetailsAPI = deleteFlightTravelDetailsAPI;
        }

        public IDeleteFlightTravelDetailsAPI DeleteFlightTravelDetailsAPI { get; }

        [HttpDelete("FlightDetails")]
        public void DeleteFlightDetails(int id)
        {
            deleteFlightDetailsAPI.DeleteFlight(id);
        }

        [HttpDelete("FlightTravelDetails")]

        public void DeleteFlightTravelDetails(int id)
        {
            DeleteFlightTravelDetailsAPI.DeleteFlightTravelInfo(id);
        }
    }
}
