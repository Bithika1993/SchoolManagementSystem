using BusinessService.Data.Repositories;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using System;
using System.Collections.Generic;

namespace BusinessService.Services
{
    public class SchoolService : ISchoolRepository
    {
        private readonly SchoolRepository sqlSchoolRepository = new SchoolRepository();
        public void Add(School entities)
        {
               sqlSchoolRepository.Add(entities);
        }

        public void Delete(int Id)
        {
                sqlSchoolRepository.Delete(Id);
        }

        public IEnumerable<School> GetAll()
        {
                var Schoollist = sqlSchoolRepository.GetAll();
                return Schoollist;
        }

        public School Get(int Id)
        {
            try
            {
                var entities = sqlSchoolRepository.Get(Id);
                return entities;
            }
            catch(Exception)
            {
                return null;
            }
        }

        public void Update(int id, School entities)
        {
                sqlSchoolRepository.update(id, entities);           
        }
    }
}
