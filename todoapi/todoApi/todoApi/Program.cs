using todoApi.Data;
using todoApi.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddDbContext<TodoDB>();

builder.Services.AddScoped<IAssignmentService, AssignmentService>();
var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
