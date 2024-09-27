using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using DAL.Repositorios.Interfaces;
using Entities;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
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

        public async Task GenerarOperacion(OperacionesEmpleados operacion)
        {
            await _context.Operaciones.AddAsync(operacion);
        }

        public async Task<Empleados> LogInEmpleado(string userName, string password)
        {
            var user = await _context.Empleados.Where(x => x.Usuario == userName && x.Passsword == password).FirstOrDefaultAsync();
            return user;
        }

        public async Task<List<LogInEmpleado>> ObtenerHorarioIngreso(int idEmpleado)
        {
            return await _context.LogIns.Include(e => e.Empleado).Where(x => x.IdEmpleado == idEmpleado).ToListAsync();
        }

        public async Task<OperacionesEmpleados> ObtenerOperacionesEmpleado(int idEmpleado)
        {
            return await _context.Operaciones.Include(e => e.Empleado).Where(x => x.IdEmpleado == idEmpleado).FirstOrDefaultAsync();
        }

        public async Task<List<OperacionesEmpleados>> ObtenerOperacionesPorEmpleadoEnSector(int idEmplead, ESectores sector)
        {
            return await _context.Operaciones.Include(e => e.Empleado).Where(x => x.Sector == sector).ToListAsync();
        }

        public async Task<int> ObtenerOperacionesPorSector(ESectores sector)
        {
            var result = await _context.Operaciones.Include(e => e.Empleado).Where(x => x.Sector == sector).CountAsync();
            return result;
        }
    }
}
