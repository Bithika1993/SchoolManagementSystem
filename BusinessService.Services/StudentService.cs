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
            try
            {
                if (student != null)
                {
                    var result = sqlStudentRepository.Add(student);
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

        public Student Delete(int id)
        {
            try
            {
                var student = sqlStudentRepository.Delete(id);
                return student;
            }
            catch(Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<Student> GetAllStudent()
        {
            try
            {
                var studentlist = sqlStudentRepository.GetAllStudent();
                return studentlist;
            }
            catch
            {
                return null;
            }
        }

        public IEnumerable<Student> GetAllStudents()
        {
            try
            {
                var studentlist = sqlStudentRepository.GetAllStudents();
                return studentlist;
            }
            catch
            {
                return null;
            }
            
        }

        public Student GetStudent(int Id)
        {
            try
            {
                var Students = sqlStudentRepository.GetStudent(Id);
                return Students;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Student Update( int id,Student student)
        {
            try
            {
                var students = sqlStudentRepository.update(id, student);
                return students;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
   
 }
