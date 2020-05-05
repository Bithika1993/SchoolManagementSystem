using BusinessService.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessService.Data.Repositories
{
    public class SqlClassRepository:Repository<Class>
    {
        BusinessServiceDbContext context = new BusinessServiceDbContext();
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
        
    }
}
