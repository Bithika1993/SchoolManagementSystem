using BusinessService.Data.Repositories;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessService.Services
{
    public class StudentService : IStudentRepository
    {
        SqlStudentRepository sqlStudentRepository = new SqlStudentRepository();

        
        public Student Add(Student student)
        {
            if (student != null)
            {
                sqlStudentRepository.Add(student);
                return null;
            }
            else
            {
                return null;
            }
        }

        public Student Delete(int id)
        {
            var student = sqlStudentRepository.Delete(id);
            return student;
        }

        public IEnumerable<Student> GetAllStudent()
        {
            var studentlist = sqlStudentRepository.GetAllStudent();
            return studentlist;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            var studentlist = sqlStudentRepository.GetAllStudents();
            return studentlist;
        }

        public Student GetStudent(int Id)
        {
           var Students= sqlStudentRepository.GetStudent(Id);
            return Students;
        }

        public Student Update( int id,Student student)
        {
            var students = sqlStudentRepository.update(id, student);
            return students;
        }
    }
   
 }
