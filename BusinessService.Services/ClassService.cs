using BusinessService.Data.Repositories;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Services
{
    public class ClassService : IClassRepository
    {
        SqlClassRepository sqlClassRepository = new SqlClassRepository();
        public Class Add(Class cls)
        {
            if(cls != null)
            {
                sqlClassRepository.Add(cls);
                return null;
            }
            else
            {
                return null;
            }
        }

        public Class Delete(int Id)
        {
            var Classes = sqlClassRepository.Delete(Id);
            return Classes;
        }

        public IEnumerable<Class> GetAllClass()
        {
            var classlist = sqlClassRepository.GetAllClass();
            return classlist;
        }

        public Class Getclass(int Id)
        {
            var classes = sqlClassRepository.GetClass(Id);
            return classes;
        }

        public Class Update(int id, Class cls)
        {
            var classes = sqlClassRepository.update(id, cls);
            return classes;
        }
    }
}
