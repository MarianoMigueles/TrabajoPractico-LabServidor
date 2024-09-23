using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services.Interface
{
    public interface IMesaService
    {
        Task<MesaDTO> CambiarEstado(int idMesa, EEstadoMesa estadoMesa);
        Task<MesaDTO> CerrarMesa(int idMesa);
    }
}
