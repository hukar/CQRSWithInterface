using CQRSWithInterface.Application.Commands;
using CQRSWithInterface.Application.Interfaces.Repository;
using CQRSWithInterface.Application.Queries.GetAllRobots;
using CQRSWithInterface.Infrastructure.Persistence.Repositories;
using MediatR;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IRobotRepository, RobotRepository>();
builder.Services.AddMediatR(typeof(Program));

var app = builder.Build();

app.MapGet("/robots", async (ISender sender) => await sender.Send(new GetAllRobotsQuery()));
// app.MapGet("/robots/{id:int}", async (ISender sender, int id) => await sender.Send(new Get))
app.MapPost("/robots", async (ISender sender, CreateRobotCommand command) 
    => await sender.Send(command));


app.Run();
