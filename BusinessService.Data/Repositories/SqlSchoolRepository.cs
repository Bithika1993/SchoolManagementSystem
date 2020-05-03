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
            try
            {
                var schooldetails = context.Schools.FirstOrDefault(e => e.Id == id);
                return schooldetails;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public IEnumerable<School> GetAllSchool()
        {
            try
            {
                var schoolList = context.Schools.ToList();
                return schoolList;
            }
            catch(Exception ex)
            {
                return null;
            }

        }
        public School Add(School school)
        {
            try
            {
                context.Schools.Add(school);
                context.SaveChanges();
                return school;
            }
            catch(Exception ex)
            {
                return null;

            }
        }
        public School update(int id, School school)
        {
            try
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
            catch(Exception ex)
            {
                return null;
            }
        }
        public School Delete(int id)
        {
            try
            {
                var schooldetail = context.Schools.FirstOrDefault(e => e.Id == id);
                if (schooldetail != null)
                {
                    context.Schools.Remove(schooldetail);
                    context.SaveChanges();
                }
                return schooldetail;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
