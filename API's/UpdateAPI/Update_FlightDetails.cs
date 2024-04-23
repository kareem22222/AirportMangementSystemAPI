using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using WebApplication8.DependencyInjections;

namespace WebApplication8.API_s.UpdateAPI
{
    public class UpdateFlightDetails : IUpdateFlightDetails
    {
        private readonly FlightDataContext flightData;

        public UpdateFlightDetails(FlightDataContext flightData)
        {
            this.flightData = flightData;
        }

        public FlightDetails GetById(int id)
        {
            return flightData.FlightDetailsModels.FirstOrDefault(f => f.FlightId == id);
        }

        public void PutFlightDetails([FromBody] FlightDetails data)
        {
            var existing = GetById(data.FlightId);
            existing.FlightName = data.FlightName??existing.FlightName;
            existing.FlightModel = data.FlightModel ?? existing.FlightModel;
            flightData.SaveChanges();
        }
    }
}
