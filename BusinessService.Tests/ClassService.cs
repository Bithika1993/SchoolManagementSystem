using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessService.Tests
{
    public class ClassService:IClassRepository
    {
        private readonly List<Class> classes;
        public ClassService()
        {
            classes = new List<Class>()
            {
                new Class{ ClassId =1,ClassName="class-5",Description="class-5"},
                 new Class{ClassId =2,ClassName="class-10",Description="class-10" },
                  new Class{ ClassId =3,ClassName="class-12",Description="class-12"},
            };
        }
        public void Add(Class entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(int Id)
        {
            throw new NotImplementedException();
        }

        public Class Get(int Id)
        {
            return classes.FirstOrDefault(a => a.ClassId == Id);
        }

        public IEnumerable<Class> GetAll()
        {
            return classes;
        }

        public void Update(int id, Class entities)
        {
            throw new NotImplementedException();
        }
    }
}
