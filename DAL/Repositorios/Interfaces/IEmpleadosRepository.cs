using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios.Interfaces
{
    public interface IEmpleadosRepository : IRepository<Empleados>
    {
        Task<List<Pedidos>> ObtenerTodosLosPedidos(); //retorna todos los pedidos dentro de cada una de las comandas
    }
}
