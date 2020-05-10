using BusinessService.Domain.Model;
using System.Linq;

namespace BusinessService.Data.Repositories
{
    public class ClassRepository:Repository<Class>
    {
        private readonly BusinessServiceDbContext context = new BusinessServiceDbContext();
        public void update(int id, Class entities)
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
        
    }
}
