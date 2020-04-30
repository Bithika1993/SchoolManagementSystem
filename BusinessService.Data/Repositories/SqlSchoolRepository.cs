using BusinessService.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessService.Data.Repositories
{
    public class SqlSchoolRepository
    {
        BusinessServiceDbContext context = new BusinessServiceDbContext();
        public School GetSchool(int id)
        {
            var schooldetails = context.Schools.FirstOrDefault(e => e.Id == id);
            return schooldetails;
        }
        public IEnumerable<School> GetAllSchool()
        {
            var schoolList = context.Schools.ToList();
            return schoolList;

        }
        public School Add(School school)
        {
            context.Schools.Add(school);
            context.SaveChanges();
            return null;
        }
        public School update(int id, School school)
        {
            var schooldetail = context.Schools.FirstOrDefault(e => e.Id == id);
            if (schooldetail != null)
            {
                schooldetail.Id = school.Id;
                schooldetail.SchoolName = school.SchoolName;
                schooldetail.SchoolType = school.SchoolType;
                schooldetail.City = school.City;
                schooldetail.Country = school.Country;
                context.SaveChanges();
            }
            return schooldetail;
        }
        public School Delete(int id)
        {
            var schooldetail = context.Schools.FirstOrDefault(e => e.Id == id);
            if (schooldetail != null)
            {
                context.Schools.Remove(schooldetail);
                context.SaveChanges();
            }
            return schooldetail;
        }
    }
}
