using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using DAL.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    internal class UnitOfWork : IUnitOfWork
    {
        public IComandasRepository ComandasRepository { get; }

        public IEmpleadosRepository EmpleadosRepository { get; }

        public IMesaRepository MesaRepository { get; }

        public IPedidosRepository PedidosRepository { get; }

        public IProductosRepository ProductosRepository { get; }

        private readonly DataContext _context;

        public UnitOfWork(
            IComandasRepository comandasRepository,
            IEmpleadosRepository empleadosRepository,
            IMesaRepository mesaRepository,
            IPedidosRepository pedidosRepository,
            IProductosRepository productosRepository,
            DataContext dataContext
            )
        {
            ComandasRepository = comandasRepository;
            EmpleadosRepository = empleadosRepository;
            MesaRepository = mesaRepository;
            PedidosRepository = pedidosRepository;
            ProductosRepository = productosRepository;
            _context = dataContext;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
