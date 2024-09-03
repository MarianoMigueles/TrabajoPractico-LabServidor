﻿using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using DAL.Repositorios.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    public class PedidosRepository : Repository<Pedidos>, IPedidosRepository
    {
        public PedidosRepository(DataContext context) : base(context)
        {
        }

        public Task<bool> CambiarEstado(string estado)
        {
            throw new NotImplementedException();
        }

        public Task<List<Pedidos>> FueraDeTiempo()
        {
            throw new NotImplementedException();
        }

        public Task<Productos> MasVendido()
        {
            throw new NotImplementedException();
        }

        public Task<Productos> MenosVendido()
        {
            throw new NotImplementedException();
        }

        public Task<string> ObtenerEstado()
        {
            throw new NotImplementedException();
        }
    }
}
