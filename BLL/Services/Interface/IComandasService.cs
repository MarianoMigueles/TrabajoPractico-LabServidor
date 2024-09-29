using BLL.DTO.Comandas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interface
{
    public interface IComandasService
    {
        Task<bool> CrearComanda(ComandaDTO comanda);
        Task<ComandaDTO> ObtenerComandaPorId(int id);
        Task<bool> EliminarComanda(int id);
    }
}
