using Ar.edu.ISTEA.TrabajoPractico_LabServidor.Dal;
using DAL.Repositorios.Interfaces;
using Exeptions;
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
            catch (DbUpdateException ex)
            {
                throw new EntityCreationException($"No se pudo crear la entidad del tipo {typeof(T).Name}. Error: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new DatabaseOperationException($"Ocurrió un error inesperado al crear la entidad del tipo {typeof(T).Name}.", ex);
            }
        }

        public void Delete(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
            }
            catch (DbUpdateException ex)
            {
                throw new EntityDeletionException($"No se pudo eliminar la entidad del tipo {typeof(T).Name}. Error: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new DatabaseOperationException($"Ocurrió un error inesperado al eliminar la entidad del tipo {typeof(T).Name}.", ex);
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
                throw new DatabaseOperationException($"No se pudo obtener una lista del tipo {typeof(T).Name}. Error: {ex.Message}", ex);
            }
        }

        public async Task<T> GetById(int id)
        {
            var result = await _context.Set<T>().FindAsync(id);
            return result ?? throw new EntityNotFoundException($"No se encontró ninguna entidad del tipo {typeof(T).Name} con el ID {id}.");
        }

        public void Update(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
            }
            catch (DbUpdateException ex)
            {
                throw new EntityUpdateException($"No se pudo actualizar la entidad del tipo {typeof(T).Name}. Error: {ex.Message}", ex);
            }
            catch (Exception ex)
            {
                throw new DatabaseOperationException($"Ocurrió un error inesperado al actualizar la entidad del tipo {typeof(T).Name}.", ex);
            }
        }

    }
}
