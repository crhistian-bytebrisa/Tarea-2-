using Microsoft.EntityFrameworkCore;
using Peliculas.Domain.Interfaces;
using Peliculas.Domain.Interfaces.Repositories;
using Peliculas.Infraestructure.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Peliculas.Infraestructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, IEntity
    {
        private readonly PeliContext _context;
        public BaseRepository(PeliContext context)
        {
            _context = context;
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>()
                .AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }        

        public virtual async Task<T> UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();            
        }
    }
}
