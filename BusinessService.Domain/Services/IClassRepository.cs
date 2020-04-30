using BusinessService.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Domain.Services
{
    public interface IClassRepository
    {
        Class Getclass(int Id);
        Class Add(Class cls);
        Class Update(int id, Class cls);
        Class Delete(int Id);
        IEnumerable<Class> GetAllClass();
    }
}
