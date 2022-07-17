using Microsoft.EntityFrameworkCore;
using Prescription.API.Data;
using Prescription.API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Add Repository Mappings
builder.Services.AddScoped<IPrescriptionRepository, PrescriptionRepository>();

//Adding DB Context
builder.Services.AddDbContext<PrescriptionDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PrecriptionContext")));

//Adding AutoMapper 
builder.Services.AddAutoMapper(typeof(Program));


var app = builder.Build();

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
