using Hardwhere_API.Context;
using Hardwhere_API.Interfaces;
using Hardwhere_API.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Permitir la conexión del backend con React
builder.Services.AddCors(x => x.AddDefaultPolicy(builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));

//AutoMapper
builder.Services.AddAutoMapper(typeof(Program));

// Add services to the container.

//Builders de mis https request.
builder.Services.AddScoped<IRepository<Component>,Repository<Component>>();
builder.Services.AddScoped<IRepository<GraphicCard>, Repository<GraphicCard>>();
builder.Services.AddScoped<IRepository<Processor>, Repository<Processor>>();
builder.Services.AddScoped<IRepository<Ram>, Repository<Ram>>();
builder.Services.AddScoped<IRepository<StorageMemory>, Repository<StorageMemory>>();
builder.Services.AddScoped<IRepository<Supply>, Repository<Supply>>();




builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
var connectionString = builder.Configuration.GetConnectionString("Hardwhere");
builder.Services.AddDbContext<HardwhereDbContext>(option => option.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
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

app.UseCors();

app.Run();
