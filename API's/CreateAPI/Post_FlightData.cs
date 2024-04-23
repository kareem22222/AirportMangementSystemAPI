using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using WebApplication8.DependencyInjections;

namespace WebApplication8.API_s.CreateAPI
{
    public class Post_FlightData : IPost_FlightData
    {
        private readonly FlightDataContext flightDataContext;

        public Post_FlightData(FlightDataContext flightDataContext)
        {
            this.flightDataContext = flightDataContext;
        }


        public FlightDetails AddFlightDetails([FromBody]FlightDetails flightDetails)
        {
           flightDataContext.FlightDetailsModels.Add(flightDetails);
            flightDataContext.SaveChanges();
            return flightDetails;

        }

    }
}
