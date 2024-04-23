using WebApplication8.Models;

namespace WebApplication8.DependencyInjections
{
    public interface IDeleteFlightTravelDetailsAPI
    {
        public FlightTravelInfo GetByFlightId(int id);
        public void DeleteFlightTravelInfo(int id);
    }
}
