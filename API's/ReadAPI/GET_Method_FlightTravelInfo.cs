using WebApplication8.Migrations;
using WebApplication8.Models;
using WebApplication8.DependencyInjections;

namespace WebApplication8.API_s.ReadAPI
{
    public class GetMethodFlightTravelInfo : IGetMethodFlightTravelInfo
    {
        private readonly FlightDataContext _flightDataContext;

        public GetMethodFlightTravelInfo(FlightDataContext flightDataContext)
        {
            _flightDataContext = flightDataContext;
        }

        public List<FlightTravelInfo> GetAllFlights()
        {
            return _flightDataContext.FlightTravelInfos.ToList();
        }

        public FlightTravelInfo GetFlight(int id)
        {
            return _flightDataContext.FlightTravelInfos.FirstOrDefault(f => f.FlightId == id);
        }

        public FlightTravelInfo GetFlightByDestination(string destination)
        {
            return _flightDataContext.FlightTravelInfos.FirstOrDefault(f => f.FlightArrivingLocation.Equals(destination));
        }
    }
}
