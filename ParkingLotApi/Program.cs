using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using ParkingLotApi.Controllers;
using ParkingLotApi.Repositories;
using ParkingLotApi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddSingleton<IMongoClient>(new MongoClient("mongodb://localhost:27017"));
builder.Services.AddSingleton<ParkingLotRepository>();
builder.Services.AddSingleton<ParkingLotService>();
builder.Services.AddSingleton<ParkingLotsController>();

var app = builder.Build();


//MongoClient mongoClient = new MongoClient(app.Configuration.GetConnectionString("MongoDB"));


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

public partial class Program { }