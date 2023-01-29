global using CQRSWithInterface.Application.Commands;
global using CQRSWithInterface.Application.Queries.GetAllRobots;
global using CQRSWithInterface.Application.Queries.GetRobotById;
global using CQRSWithInterface.Application.Interfaces.Repository;
global using CQRSWithInterface.Application.Interfaces;

global using CQRSWithInterface.Infrastructure.Persistence.Repositories;

global using CQRSWithInterface.Models;

global using CQRSWithInterface.API.RobotEndpoints; 
global using CQRSWithInterface.API.Middlewares;


global using MediatR;