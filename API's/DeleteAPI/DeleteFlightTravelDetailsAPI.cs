using WebApplication8.Models;
using WebApplication8.DependencyInjections;

namespace WebApplication8.API_s.DeleteAPI
{
    public class DeleteFlightTravelDetailsAPI : IDeleteFlightTravelDetailsAPI
    {
        private readonly FlightDataContext flightDataContext;

        public DeleteFlightTravelDetailsAPI(FlightDataContext flightDataContext)
        {
            this.flightDataContext = flightDataContext;
        }

        public FlightTravelInfo GetByFlightId(int id) 
        {
            return flightDataContext.FlightTravelInfos.FirstOrDefault(f => f.FlightId == id);
        }

        public void DeleteFlightTravelInfo(int id)
        {
            flightDataContext.FlightTravelInfos.Remove(GetByFlightId(id));
            flightDataContext.SaveChanges();
        }

    }
}
