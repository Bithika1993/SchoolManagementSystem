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
        public void Add(Class cls)
        {
            try
            {
                sqlClassRepository.Add(cls);
            }
            catch(Exception ex)
            {
            }
        }

        public void Delete(int Id)
        {
            try
            {
                sqlClassRepository.Delete(Id);
            }
            catch(Exception ex)
            {
            }
        }

        public IEnumerable<Class> GetAll()
        {
            try
            {
                var classlist = sqlClassRepository.GetAll();
                return classlist;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public Class Get(int Id)
        {
            try
            {
                var classes = sqlClassRepository.Get(Id);
                return classes;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public void Update(int id, Class cls)
        {
            try
            {
                sqlClassRepository.update(id, cls);
            }
            catch(Exception ex)
            {
            }
        }
    }
}
