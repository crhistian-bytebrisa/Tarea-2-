using System;
using System.Collections.Generic;
using System.Text;

namespace Peliculas.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class, IEntity
    {
        public T GetByIdAsync(int id);
        public List<T> GetAll();
        public T Add(T entity);
        public T Update(T entity);
        public void Delete(T entity);
    }
}
