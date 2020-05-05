using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessService.Data.Repositories
{
    public class Repository<TEntity> where TEntity:class
    {
        BusinessServiceDbContext context = new BusinessServiceDbContext();
        public TEntity Get(int id)
        {
            try
            {
                return context.Set<TEntity>().Find(id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IEnumerable<TEntity> GetAll()
        {
            try
            {
                return context.Set<TEntity>().ToList();
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public void Add(TEntity entities)
        {
            try
            {
                context.Set<TEntity>().Add(entities);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
            }
        }
        public void Delete(int id)
        {
            try
            {
                var result = context.Set<TEntity>().Find(id);
                if (result != null)
                {
                    context.Set<TEntity>().Remove(result);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
            }
        }

    }
}
