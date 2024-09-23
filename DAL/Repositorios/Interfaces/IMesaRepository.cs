using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< Updated upstream
=======
using Entities;
using Entities.Enums;
>>>>>>> Stashed changes

namespace DAL.Repositorios.Interfaces
{
    internal interface IMesaRepository
    {
<<<<<<< Updated upstream
=======
        Task<Mesas> CambiarEstado(int idMesa, EEstadoMesa estadoMesa);
        Task<Mesas> CerrarMesa(int idMesa);
>>>>>>> Stashed changes
    }
}
