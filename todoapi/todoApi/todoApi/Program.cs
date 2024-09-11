using todoApi.Data;
using todoApi.Data.Models;
using todoApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<TodoDB>();

builder.Services.AddScoped<IAssignmentService, AssignmentService>();
var app = builder.Build();

app.Run();
