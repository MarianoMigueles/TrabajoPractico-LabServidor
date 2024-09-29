using Entities;
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
        void RellenarStock(int idProducto, int stock);
        void ReducirStock(int idProducto, int stock);


    }
}
