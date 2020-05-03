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
        public Class Add(Class classs)
        {
            try
            {
                context.classes.Add(classs);
                context.SaveChanges();
                return classs;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public Class update(int id, Class classs)
        {
            try
            {
                var classdetail = context.classes.FirstOrDefault(e => e.ClassId == id);
                if (classdetail != null)
                {
                    classdetail.ClassId = classs.ClassId;
                    classdetail.ClassName = classs.ClassName;
                    classdetail.Description = classs.Description;
                    context.SaveChanges();
                }
                return classdetail;
            }
            catch
            {
                return null;
            }
        }
        public Class Delete(int id)
        {
            try
            {
                var classdetail = context.classes.FirstOrDefault(e => e.ClassId == id);
                if (classdetail != null)
                {
                    context.classes.Remove(classdetail);
                    context.SaveChanges();
                }
                return classdetail;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
