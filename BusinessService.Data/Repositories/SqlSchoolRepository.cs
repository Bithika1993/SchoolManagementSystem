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
        public void Add(School entities)
        {
            try
            {
                context.Schools.Add(entities);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
            }
        }
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
        public void Delete(int id)
        {
            try
            {
                var schooldetail = context.Schools.FirstOrDefault(e => e.Id == id);
                if (schooldetail != null)
                {
                    context.Schools.Remove(schooldetail);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
            }
        }
    }
}
