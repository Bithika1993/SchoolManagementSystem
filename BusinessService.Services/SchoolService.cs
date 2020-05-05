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
        public void Add(School entities)
        {
            try
            {
               sqlSchoolRepository.Add(entities);
            }
            catch(Exception ex)
            {
            }
        }

        public void Delete(int Id)
        {
            try
            {
                sqlSchoolRepository.Delete(Id);
            }
            catch(Exception ex)
            {
            }
        }

        public IEnumerable<School> GetAll()
        {
            try
            {
                var Schoollist = sqlSchoolRepository.GetAll();
                return Schoollist;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public School Get(int Id)
        {
            try
            {
                var entities = sqlSchoolRepository.Get(Id);
                return entities;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public void Update(int id, School entities)
        {
            try
            {
                sqlSchoolRepository.update(id, entities);
            }
            catch(Exception ex)
            {
            }
        }
    }
}
