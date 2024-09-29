using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using DAL.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositorios
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DataContext _context;
        public Repository(DataContext context)
        {
            _context = context;
        }
        public async Task Create(T entity)
        {          
            try
            {
                await _context.Set<T>().AddAsync(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"No se pudo actualizar la entidad del tipo {typeof(T).Name}. Error: {ex.Message}");
            }

        }

        public void Delete(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"No se pudo eliminar la entidad del tipo {typeof(T).Name}. Error: {ex.Message}");
            }           
        }

        public async Task<List<T>> GetAll()
        {
            try
            {
                return await _context.Set<T>().ToListAsync();
            } 
            catch (Exception ex)
            {
                throw new Exception($"No se pudo obtener una lista del tipo {typeof(T).Name}. Error: {ex.Message}");
            }
            
        }

        public async Task<T> GetById(int id)
        {
            var result = await _context.Set<T>().FindAsync(id);
            return result?? throw new Exception($"no se encontro ningun {typeof(T).Name} con el id {id}.");
        }

        public void Update(T entity)
        {           
            try
            {
                _context.Set<T>().Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"No se pudo actualizar la entidad del tipo {typeof(T).Name}. Error: {ex.Message}");
            }
        }
    }
}
