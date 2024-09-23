using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Entities.Enums;

namespace DAL.Repositorios.Interfaces
{
    public interface IMesaRepository : IRepository<Mesas>
    {
        Task<Mesas> CambiarEstado(int idMesa, EEstadoMesa estadoMesa);
        Task<Mesas> CerrarMesa(int idMesa);
    }
}
