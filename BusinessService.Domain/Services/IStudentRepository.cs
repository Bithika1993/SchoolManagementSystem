using BusinessService.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Domain.Services
{
    public interface IStudentRepository:IRepository<Student>
    {
        IEnumerable<Student> GetAllStudentsDetails();
        IEnumerable<Student> GetStudentsBySchoolId(int id);
    }
}
