using BusinessService.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Domain.Services
{
    public interface IStudentRepository
    { 
            Student GetStudent(int Id);
            Student Add(Student student);
            Student Update(int id,Student student);
            Student Delete(int Id);
            IEnumerable<Student> GetAllStudent();
    }
}
