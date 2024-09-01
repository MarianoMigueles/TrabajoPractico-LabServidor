using DAL.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    internal interface IUnitOfWork : IDisposable
    {
        IComandasRepository ComandasRepository { get; }
        IEmpleadosRepository EmpleadosRepository { get; }
        IMesaRepository MesaRepository { get; }
        IPedidosRepository PedidosRepository { get; }
        IProductosRepository ProductosRepository { get; }
        Task<int> Save();
    }
}
