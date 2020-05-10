
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessService.Data.Repositories
{
    public class Repository<TEntity> where TEntity:class
    {
        private readonly BusinessServiceDbContext context = new BusinessServiceDbContext();
        public TEntity Get(int id)
        {
            try
            {
                return context.Set<TEntity>().Find(id);
            }
            catch (Exception)
            {
                return null;
            }
        }
        public IEnumerable<TEntity> GetAll()
        {
                return context.Set<TEntity>().ToList();

        }
        public void Add(TEntity entities)
        {
                context.Set<TEntity>().Add(entities);
                context.SaveChanges();
            
        }
        public void Delete(int id)
        {
                var result = context.Set<TEntity>().Find(id);
                if (result != null)
                {
                    context.Set<TEntity>().Remove(result);
                    context.SaveChanges();
                
                }
        }

    }
}
