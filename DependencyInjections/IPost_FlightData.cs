using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;

namespace WebApplication8.DependencyInjections
{
    public interface IPost_FlightData
    {
        public FlightDetails AddFlightDetails([FromBody] FlightDetails flightDetails);
    }
}
