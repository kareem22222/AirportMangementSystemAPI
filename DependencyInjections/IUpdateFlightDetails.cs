using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;

namespace WebApplication8.DependencyInjections
{
    public interface IUpdateFlightDetails
    {
        public FlightDetails GetById(int id);
        public void PutFlightDetails([FromBody] FlightDetails data);
    }
}
