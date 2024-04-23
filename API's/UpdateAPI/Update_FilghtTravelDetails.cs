using WebApplication8.Models;
using WebApplication8.DependencyInjections;

namespace WebApplication8.API_s.UpdateAPI
{
    public class FlightTravelDetailsUpdateAPI : IUpdateFlightTravelDetailsAPI
    {
        private readonly FlightDataContext _flightDataContext;

        public FlightTravelDetailsUpdateAPI(FlightDataContext flightDataContext)
        {
            _flightDataContext = flightDataContext;
        }

        public void UpdateFlightTravelInfo(int id, string arrivingLocation, string departureLocation)
        {
            var flightTravelInfo = _flightDataContext.FlightTravelInfos.FirstOrDefault(x => x.FlightId == id);

            if (flightTravelInfo != null)
            {
                flightTravelInfo.FlightArrivingLocation = arrivingLocation;
                flightTravelInfo.FlightDepartureLocation = departureLocation;

                _flightDataContext.SaveChanges();
            }
        }

        public void UpdateFlightTravelClass(int id, string flightClass)
        {
            var flightTravelInfo = _flightDataContext.FlightTravelInfos.FirstOrDefault(x => x.FlightId == id);

            if (flightTravelInfo != null)
            {
                flightTravelInfo.FlightClass = flightClass;
                _flightDataContext.SaveChanges();
            }
        }
    }
}