var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IRobotRepository, RobotRepository>();
builder.Services.AddMediatR(typeof(Program));

var app = builder.Build();

app.MapRobots();


app.Run();
