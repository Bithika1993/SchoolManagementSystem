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
            var classdetails = context.classes.FirstOrDefault(e => e.ClassId == id);
            return classdetails;
        }
        public IEnumerable<Class> GetAllClass()
        {
            var classsList = context.classes.ToList();
            return classsList;

        }
        public Class Add(Class classs)
        {
            context.classes.Add(classs);
            context.SaveChanges();
            return null;
        }
        public Class update(int id, Class classs)
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
        public Class Delete(int id)
        {
            var classdetail = context.classes.FirstOrDefault(e => e.ClassId == id);
            if (classdetail != null)
            {
                context.classes.Remove(classdetail);
                context.SaveChanges();
            }
            return classdetail;
        }
    }
}
