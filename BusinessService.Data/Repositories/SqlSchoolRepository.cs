using BusinessService.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessService.Data.Repositories
{
    public class SqlSchoolRepository:Repository<School>
    {
        BusinessServiceDbContext context = new BusinessServiceDbContext();
        public void update(int id, School entities)
        {
            try
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
            catch(Exception ex)
            {
            }
        }
    }
}
