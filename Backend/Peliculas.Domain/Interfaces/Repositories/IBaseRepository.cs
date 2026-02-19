using System;
using System.Collections.Generic;
using System.Text;

namespace Peliculas.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class, IEntity
    {
        public Task<T> GetByIdAsync(int id);
        public Task<List<T>> GetAllAsync();
        public Task<T> AddAsync(T entity);
        public Task<T> UpdateAsync(T entity);
        public Task DeleteAsync(T entity);
    }
}
