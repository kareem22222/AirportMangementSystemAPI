using WebApplication8.Models;

namespace WebApplication8.DependencyInjections
{
    public interface IGetMethodFlightTravelInfo
    {
        public FlightTravelInfo GetFlightByDestination(string destination);
        public List<FlightTravelInfo> GetAllFlights();
        public FlightTravelInfo GetFlight(int id);
    }
}
