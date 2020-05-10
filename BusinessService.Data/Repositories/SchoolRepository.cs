using BusinessService.Domain.Model;
using System.Linq;

namespace BusinessService.Data.Repositories
{
    public class SchoolRepository:Repository<School>
    {
        private readonly BusinessServiceDbContext context = new BusinessServiceDbContext();
        public void update(int id, School entities)
        {
                var schooldetail = context.Schools.FirstOrDefault(e => e.Id == id);
                if (schooldetail != null)
                {
                    schooldetail.Id = entities.Id;
                    schooldetail.SchoolName = entities.SchoolName;
                    schooldetail.SchoolType = entities.SchoolType;
                    schooldetail.City = entities.City;
                    schooldetail.Country = entities.Country;
                    context.SaveChanges();
                }
        }
    }
}
