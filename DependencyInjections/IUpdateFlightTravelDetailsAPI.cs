namespace WebApplication8.DependencyInjections
{
    public interface IFlightTravelDetailsUpdateAPI
    {
        public void UpdateFlightTravelInfo(int id, string arrivingLocation, string departureLocation);
        public void UpdateFlightTravelClass(int id, string flightClass);
    }
}
