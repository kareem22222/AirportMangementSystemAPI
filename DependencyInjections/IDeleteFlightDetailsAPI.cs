using WebApplication8.Models;

namespace WebApplication8.DependencyInjections
{
    public interface IDeleteFlightDetailsAPI
    {
        public FlightDetails GetFlightById(int id);
        public void DeleteFlight(int id);
    }
}
