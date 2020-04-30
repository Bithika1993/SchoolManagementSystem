using BusinessService.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Domain.Services
{
    public interface ISchoolRepository
    {
        School GetSchool(int Id);
        School Add(School school);
        School Update(int id, School school);
        School Delete(int Id);
        IEnumerable<School> GetAllSchool();
    }
}
