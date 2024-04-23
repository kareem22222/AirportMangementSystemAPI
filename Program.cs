using Microsoft.EntityFrameworkCore;
using WebApplication8.API_s.CreateAPI;
using WebApplication8.API_s.DeleteAPI;
using WebApplication8.API_s.ReadAPI;
using WebApplication8.API_s.UpdateAPI;
using WebApplication8.Controllers;
using WebApplication8.DependencyInjections;
using WebApplication8.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<FlightDataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("FlightMS")));

builder.Services.AddScoped<IGetMethodsFlightData,GetMethodsFlightData>();
builder.Services.AddScoped<IGetMethodFlightTravelInfo,GetMethodFlightTravelInfo>();
builder.Services.AddScoped<IPost_FlightData,Post_FlightData>();
builder.Services.AddScoped<IPost_FlightTravelData,Post_FlightTravelData>();
builder.Services.AddScoped<IUpdateFlightDetails,UpdateFlightDetails>();
builder.Services.AddScoped<IUpdateFlightTravelDetailsAPI, FlightTravelDetailsUpdateAPI>();
builder.Services.AddScoped<IDeleteFlightDetailsAPI, DeleteFlightDetailsAPI>();
builder.Services.AddScoped<IDeleteFlightTravelDetailsAPI, DeleteFlightTravelDetailsAPI>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
