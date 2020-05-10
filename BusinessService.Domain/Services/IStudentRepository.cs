using BusinessService.Domain.Model;
using System.Collections.Generic;

namespace BusinessService.Domain.Services
{
    public interface IStudentRepository:IRepository<Student>
    {
        IEnumerable<Student> GetAllStudentsDetails();
        IEnumerable<Student> GetStudentsBySchoolId(int id);
    }
}
