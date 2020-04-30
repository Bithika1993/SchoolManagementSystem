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
            if (school != null)
            {
                sqlSchoolRepository.Add(school);
                return null;
            }
            else
            {
                return null;
            }
        }

        public School Delete(int Id)
        {
            var school = sqlSchoolRepository.Delete(Id);
            return school;
        }

        public IEnumerable<School> GetAllSchool()
        {
            var Schoollist = sqlSchoolRepository.GetAllSchool();
            return Schoollist;
        }

        public School GetSchool(int Id)
        {
            var school = sqlSchoolRepository.GetSchool(Id);
            return school;
        }

        public School Update(int id, School school)
        {
            var schools = sqlSchoolRepository.update(id, school);
            return schools;
        }
    }
}
