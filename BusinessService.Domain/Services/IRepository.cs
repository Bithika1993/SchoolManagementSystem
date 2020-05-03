using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Domain.Services
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int Id);
        void Add(TEntity entities);
        void Update(int id, TEntity entities);
        void Delete(int Id);
        IEnumerable<TEntity> GetAll();
    }
}
