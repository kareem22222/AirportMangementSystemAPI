using WebApplication8.Models;

namespace WebApplication8.DependencyInjections
{
    public interface IGetMethodsFlightData
    {
        public List<FlightDetails> GetAllFlights();
        public FlightDetails GetFlightById(int id);
    }
}
