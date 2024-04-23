using WebApplication8.Models;
using WebApplication8.DependencyInjections;

namespace WebApplication8.API_s.ReadAPI
{
    public class GetMethodsFlightData : IGetMethodsFlightData
    {
        private readonly FlightDataContext _flightDataContext;

        public GetMethodsFlightData( FlightDataContext flightDataContext)
        {
            _flightDataContext = flightDataContext;
        }

        public List<FlightDetails> GetAllFlights()
        {
            return _flightDataContext.FlightDetailsModels.ToList();
        }

        public FlightDetails GetFlightById(int id)
        {
            return _flightDataContext.FlightDetailsModels.FirstOrDefault(f => f.FlightId == id);
        }
    }

}
