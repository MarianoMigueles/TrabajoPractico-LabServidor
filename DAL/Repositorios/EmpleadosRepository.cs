using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using DAL.Repositorios.Interfaces;
using Entities;
using Entities.Enums;
using Exeptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    public class EmpleadosRepository(DataContext context) : Repository<Empleados>(context), IEmpleadosRepository
    {
        public async Task<Empleados> ActualizarEstadoEmpleado(int idEmpleado, EEstadoEmpleado estado)
        {
            var result = await this.GetById(idEmpleado);
            result.Estado = estado;
            return result;
        }

        public async Task<Empleados> ObtenerEmpleadoPorNombreUsuario(string usuario)
        {
            return await _context.Empleados.Where(x => x.Usuario.Equals(usuario)).FirstOrDefaultAsync();
        }

        public async Task GenerarInicioSecion(LogInEmpleado empleado)
        {
            await _context.LogIns.AddAsync(empleado);
        }

        public async Task GenerarOperacion(OperacionesEmpleados operacion)
        {
            await _context.Operaciones.AddAsync(operacion);
        }

        public async Task<Empleados> LogInEmpleado(string userName, string password)
        {
            var user = await _context.Empleados.Where(x => x.Usuario == userName && x.Password == password).FirstOrDefaultAsync();
            return user?? throw new EntityNotFoundException($"El nombre de usuario o la contraseña no son validos.");
        }

        public async Task<List<LogInEmpleado>> ObtenerHorarioIngreso(int idEmpleado)
        {
            return await _context.LogIns.Include(e => e.Empleado).Where(x => x.IdEmpleado == idEmpleado).ToListAsync();
        }

        public async Task<List<OperacionesEmpleados>> ObtenerOperacionesEmpleado(int idEmpleado)
        {
            return await _context.Operaciones.Include(e => e.Empleado).Where(x => x.IdEmpleado == idEmpleado).ToListAsync();
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
