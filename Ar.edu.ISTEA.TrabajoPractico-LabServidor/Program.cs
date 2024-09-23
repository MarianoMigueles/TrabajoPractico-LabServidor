<<<<<<< Updated upstream
=======
using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using BLL.Services;
using BLL.Services.Interface;
using DAL.Repositorios;
using DAL.Repositorios.Interfaces;
using DAL.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;

>>>>>>> Stashed changes
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

<<<<<<< Updated upstream
=======
//INYECCIONES
builder.Services.AddScoped<IComandasRepository, ComandasRepository>();
builder.Services.AddScoped<IEmpleadosRepository, EmpleadosRepository>();
builder.Services.AddScoped<IMesaRepository, MesaRepository>();
builder.Services.AddScoped<IPedidosRepository, PedidosRepository>();
builder.Services.AddScoped<IProductosRepository, ProductosRepository>();

//UNIT OF WORK
builder.Services.AddScoped<IUnitOfWork,  UnitOfWork>();

>>>>>>> Stashed changes
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
