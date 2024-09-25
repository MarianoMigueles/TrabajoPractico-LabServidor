using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using DAL.Repositorios.Interfaces;
using Entities;
using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    public class EmpleadosRepository : Repository<Empleados>, IEmpleadosRepository
    {
        public EmpleadosRepository(DataContext context) : base(context)
        {
        }

        public async Task<Empleados> ActualizarEstadoEmpleado(int idEmpleado, EEstadoEmpleado estado)
        {
            var result = await this.GetById(idEmpleado);
            result.Estado = estado;
            return result;
        }
    }
}
