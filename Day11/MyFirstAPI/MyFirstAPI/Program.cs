using Microsoft.EntityFrameworkCore;
using MyFirstAPI.Models;
using MyFirstAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();//OPenn API Support


builder.Services.AddDbContext<CompanyContext>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("empCon"));
});
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IRepo<int, Employee>, EmployeeDbRepo>();
builder.Services.AddScoped<IRepo<string, User>, UserRepo>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
