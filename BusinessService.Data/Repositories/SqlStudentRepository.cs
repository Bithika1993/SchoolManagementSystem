using BusinessService.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessService.Data.Repositories
{
    public class SqlStudentRepository
    {
        BusinessServiceDbContext context= new BusinessServiceDbContext();  
        public Student GetStudent(int id)
        {
            try
            {
                var studentdetails = context.Students.Where(e => e.Id == id)
                          .Include(c => c.classes)
                          .Include(p => p.course)
                          .Include(s => s.school)
                          .First();
                return studentdetails;
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
                var studentList = context.Students.ToList();
                return studentList;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public IEnumerable<Student> GetAllStudents()
        {
            try
            {
                var studentDetail = context.Students
                          .Include(c => c.classes)
                          .Include(p => p.course)
                          .Include(s => s.school)
                          .ToList();
                return studentDetail;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public void Add(Student entities)
        {
            try
            {
                context.Students.Add(entities);
                context.SaveChanges();
            }
            catch(Exception ex)
            {
            }
        }
        public void update(int id,Student entities)
        {
            try
            {
                var studentdetail = context.Students.FirstOrDefault(e => e.Id == id);
                if (studentdetail != null)
                {
                    studentdetail.Id = entities.Id;
                    studentdetail.Name = entities.Name;
                    studentdetail.DOB = entities.DOB;
                    studentdetail.Gender = entities.Gender;
                    studentdetail.ClassId = entities.ClassId;
                    studentdetail.CourseId = entities.CourseId;
                    studentdetail.SchoolId = entities.SchoolId;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
            }
        }
        public void Delete(int id)
        {
            try
            {
                var studentdetail = context.Students.FirstOrDefault(e => e.Id == id);
                if (studentdetail != null)
                {
                    context.Students.Remove(studentdetail);
                    context.SaveChanges();
                }
            }
            catch(Exception ex)
            {
            }
        }
    }
}
