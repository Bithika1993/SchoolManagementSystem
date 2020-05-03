using BusinessService.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessService.Data.Repositories
{
    public class SqlClassRepository
    {
        BusinessServiceDbContext context = new BusinessServiceDbContext();
        public Class GetClass(int id)
        {
            try
            {
                var classdetails = context.classes.FirstOrDefault(e => e.ClassId == id);
                return classdetails;
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<Class> GetAllClass()
        {
            try
            {
                var classsList = context.classes.ToList();
                return classsList;
            }
            catch
            {
                return null;
            }

        }
        public void Add(Class entities)
        {
            try
            {
                context.classes.Add(entities);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
            }
        }
        public void update(int id, Class entities)
        {
            try
            {
                var classdetail = context.classes.FirstOrDefault(e => e.ClassId == id);
                if (classdetail != null)
                {
                    classdetail.ClassId = entities.ClassId;
                    classdetail.ClassName = entities.ClassName;
                    classdetail.Description = entities.Description;
                    context.SaveChanges();
                }
            }
            catch
            {
            }
        }
        public void Delete(int id)
        {
            try
            {
                var classdetail = context.classes.FirstOrDefault(e => e.ClassId == id);
                if (classdetail != null)
                {
                    context.classes.Remove(classdetail);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
            }
        }
    }
}
