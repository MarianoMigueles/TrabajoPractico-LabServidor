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
    public class ProductosRepository : Repository<Productos>, IProductosRepository
    {
        public ProductosRepository(DataContext context) : base(context)
        {
        }

        public Task<Productos> MasVendido()
        {
            throw new NotImplementedException();
        }

        public Task<Productos> MenosVendido()
        {
            throw new NotImplementedException();
        }
    }
}
