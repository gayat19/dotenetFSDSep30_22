using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using MyFirstAPI.Models;
using MyFirstAPI.Services;
using System.Text;
using Microsoft.Extensions.Logging.Log4Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();//OPenn API Support
builder.Services.AddCors(options =>
{
    options.AddPolicy("MyCors", opts =>
    {
        opts.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["TokenKey"])),
            ValidateIssuer = false,
            ValidateAudience= false
        };
    });


builder.Services.AddDbContext<CompanyContext>(option => {
    option.UseSqlServer(builder.Configuration.GetConnectionString("empCon"));
});
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IRepo<int, Employee>, EmployeeDbRepo>();
builder.Services.AddScoped<IRepo<string, User>, UserRepo>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddLogging(opts =>
{
    opts.AddLog4Net();
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseCors("MyCors");
app.UseAuthorization();

app.UseHttpLogging();

app.MapControllers();

app.Run();
