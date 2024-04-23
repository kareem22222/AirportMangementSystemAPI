using WebApplication8.Models;
using WebApplication8.DependencyInjections;

namespace WebApplication8.API_s.DeleteAPI
{
    public class DeleteFlightDetailsAPI : IDeleteFlightDetailsAPI
    {
        private readonly FlightDataContext flightDataContext;

        public DeleteFlightDetailsAPI(FlightDataContext flightDataContext)
        {
            this.flightDataContext = flightDataContext;
        }

        public FlightDetails GetFlightById(int id)
        {
            return flightDataContext.FlightDetailsModels.FirstOrDefault(f => f.FlightId==id);
        }

        public void DeleteFlight(int id)
        {
            flightDataContext.FlightDetailsModels.Remove(GetFlightById(id));
            flightDataContext.SaveChanges();
        }

    }
}
