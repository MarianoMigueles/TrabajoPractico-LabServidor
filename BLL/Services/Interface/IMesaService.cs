using BLL.DTO.Empleados;
using BLL.DTO.Mesas;
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
        Task<bool> CrearMesa(MesaDTO mesa);
        Task<MesaDTO> ObtenerMesaPorId(int id);
        Task<bool> EliminarMesa(int id);
    }
}
