using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessService.Tests
{
    public class SchoolService : ISchoolRepository
    {
        private readonly List<School> schools;
        public SchoolService()
        {
            schools = new List<School>()
            {
                new School{ Id =1,SchoolName="School1",City="Kolkata"},
                 new School{Id =2,SchoolName="School2",City="Kolkata" },
                  new School{ Id =3,SchoolName="School3",City="Kolkata"},
            };
        }
        public void Add(School entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public School Get(int Id)
        {
            return schools.FirstOrDefault(a => a.Id == Id);
        }

        public IEnumerable<School> GetAll()
        {
            return schools;
        }

        public void Update(int id, School entities)
        {
            throw new NotImplementedException();
        }
    }
}
