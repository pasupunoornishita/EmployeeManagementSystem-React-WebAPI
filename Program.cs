using EmployeeManagementAPI.Data;
using EmployeeManagementAPI.Repository;
using EmployeeManagementAPI.Facade;
using EmployeeManagementAPI.Singleton;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

Console.WriteLine(
    builder.Configuration.GetConnectionString("DefaultConnection")
);

builder.Services.AddControllers();

builder.Services.AddDbContext<AppDbContext>(
    options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString(
            "DefaultConnection")));

builder.Services.AddScoped<
    IEmployeeRepository,
    EmployeeRepository>();

builder.Services.AddScoped<EmployeeFacade>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddPolicy(
        "AllowAngular",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAngular");

app.MapGet("/", () => "Employee API is running. Use /api/Employees");

app.MapControllers();

Logger.Instance.Log("Application Started");

app.Run();