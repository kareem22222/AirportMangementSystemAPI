using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using WebApplication8.DependencyInjections;

namespace WebApplication8.API_s.CreateAPI
{
    public class Post_FlightTravelData : IPost_FlightTravelData
    {
        private readonly FlightDataContext flightDataContext;

        public Post_FlightTravelData(FlightDataContext flightDataContext)
        {
            this.flightDataContext = flightDataContext;
        }


        public FlightTravelInfo AddFlightTravelInfo(FlightTravelInfo flightTravelInfo)
        {
            flightDataContext.FlightTravelInfos.Add(flightTravelInfo);
            flightDataContext.SaveChanges();
            return flightTravelInfo;
        }
    }
}
