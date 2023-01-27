using CQRSWithInterface.Application.Interfaces;
using CQRSWithInterface.Application.Queries.GetAllRobots;
using CQRSWithInterface.Infrastructure;
using MediatR;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IRobotRepository, RobotRepository>();
builder.Services.AddMediatR(typeof(Program));

var app = builder.Build();

app.MapGet("/", async (ISender sender) => await sender.Send(new GetAllRobotsQuery()));

app.Run();
