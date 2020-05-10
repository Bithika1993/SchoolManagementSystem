using BusinessService.Data.Repositories;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using System;
using System.Collections.Generic;

namespace BusinessService.Services
{
    public class ClassService : IClassRepository
    {
        private readonly  ClassRepository sqlClassRepository = new ClassRepository();
        public void Add(Class entities)
        {
                sqlClassRepository.Add(entities);
        }

        public void Delete(int Id)
        {
                sqlClassRepository.Delete(Id);
        }

        public IEnumerable<Class> GetAll()
        {
                var classlist = sqlClassRepository.GetAll();
                return classlist;
        }

        public Class Get(int Id)
        {
            try
            {
                var classes = sqlClassRepository.Get(Id);
                return classes;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public void Update(int id, Class entities)
        {
                sqlClassRepository.update(id, entities);
        }
    }
}
