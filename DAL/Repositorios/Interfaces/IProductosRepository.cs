﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios.Interfaces
{
    public interface IProductosRepository : IRepository<Productos>
    {
        Task<Productos> MasVendido();
        Task<Productos> MenosVendido();
        void RellenarStock(Productos producto, int stock);
        void ReducirStock(Productos producto, int stock);


    }
}
