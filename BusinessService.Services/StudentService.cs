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
        public void Add(Student entities)
        {
            try
            {
                sqlStudentRepository.Add(entities);
            }
            catch(Exception ex)
            {
            }
        }

        public void Delete(int id)
        {
            try
            {
                sqlStudentRepository.Delete(id);
            }
            catch(Exception ex)
            {
            }
        }

        public IEnumerable<Student> GetAll()
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

        public Student Get(int Id)
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

        public void Update( int id,Student entities)
        {
            try
            {
                sqlStudentRepository.update(id, entities);
            }
            catch(Exception ex)
            {
            }
        }
    }
   
 }
