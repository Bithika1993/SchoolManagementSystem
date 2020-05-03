using BusinessService.Data.Repositories;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Services
{
    public class SchoolService : ISchoolRepository
    {
        SqlSchoolRepository sqlSchoolRepository = new SqlSchoolRepository();
        public School Add(School school)
        {
            try
            {
                if (school != null)
                {
                    var result = sqlSchoolRepository.Add(school);
                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public School Delete(int Id)
        {
            try
            {
                var school = sqlSchoolRepository.Delete(Id);
                return school;
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
                var Schoollist = sqlSchoolRepository.GetAllSchool();
                return Schoollist;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public School GetSchool(int Id)
        {
            try
            {
                var school = sqlSchoolRepository.GetSchool(Id);
                return school;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public School Update(int id, School school)
        {
            try
            {
                var schools = sqlSchoolRepository.update(id, school);
                return schools;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
