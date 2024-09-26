
using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using BLL.Automapper;
using BLL.Services;
using BLL.Services.Interface;
using DAL.Repositorios;
using DAL.Repositorios.Interfaces;
using DAL.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//--------------ConnectionString------------------------ 
builder.Services.AddDbContext<DataContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CadenaSQL"));
});

//INYECCIONES
builder.Services.AddScoped<IComandasRepository, ComandasRepository>();
builder.Services.AddScoped<IEmpleadosRepository, EmpleadosRepository>();
builder.Services.AddScoped<IMesaRepository, MesaRepository>();
builder.Services.AddScoped<IPedidosRepository, PedidosRepository>();
builder.Services.AddScoped<IProductosRepository, ProductosRepository>();

builder.Services.AddScoped<IComandasService, ComandasService>(); 
builder.Services.AddScoped<IEmpleadosService, EmpleadosService>();
builder.Services.AddScoped<IMesaService, MesaService>();
builder.Services.AddScoped<IPedidosService, PedidosService>();
builder.Services.AddScoped<IProductosService, ProductosService>();

//UNIT OF WORK
builder.Services.AddScoped<IUnitOfWork,  UnitOfWork>();

// Configure AutoMapper
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddAutoMapper(typeof(AutomapperProfile));

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
