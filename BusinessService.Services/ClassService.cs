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
            try
            {
                if (cls != null)
                {
                    var result = sqlClassRepository.Add(cls);
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

        public Class Delete(int Id)
        {
            try
            {
                var Classes = sqlClassRepository.Delete(Id);
                return Classes;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<Class> GetAllClass()
        {
            try
            {
                var classlist = sqlClassRepository.GetAllClass();
                return classlist;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public Class Getclass(int Id)
        {
            try
            {
                var classes = sqlClassRepository.GetClass(Id);
                return classes;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public Class Update(int id, Class cls)
        {
            try
            {
                var classes = sqlClassRepository.update(id, cls);
                return classes;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
