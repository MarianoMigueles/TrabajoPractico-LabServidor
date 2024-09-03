using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using DAL.Repositorios.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    public class MesaRepository : Repository<Mesas>, IMesaRepository
    {
        public MesaRepository(DataContext context) : base(context)
        {
        }

        public Task<bool> CambiarEstado(string estado)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CerrarMesa(int idMesa)
        {
            throw new NotImplementedException();
        }

        public Task<Pedidos> IdentificarPedido(int codigo)
        {
            throw new NotImplementedException();
        }

        public Task<Pedidos> ObtenerPedidoEnPreparacion(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}
