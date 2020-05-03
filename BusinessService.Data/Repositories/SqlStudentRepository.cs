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
        public Student Add(Student student)
        {
            try
            {
                context.Students.Add(student);
                context.SaveChanges();
                return student;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public Student update(int id,Student student)
        {
            try
            {
                var studentdetail = context.Students.FirstOrDefault(e => e.Id == id);
                if (studentdetail != null)
                {
                    studentdetail.Id = student.Id;
                    studentdetail.Name = student.Name;
                    studentdetail.DOB = student.DOB;
                    studentdetail.Gender = student.Gender;
                    studentdetail.ClassId = student.ClassId;
                    studentdetail.CourseId = student.CourseId;
                    studentdetail.SchoolId = student.SchoolId;
                    context.SaveChanges();
                }
                return studentdetail;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public Student Delete(int id)
        {
            try
            {
                var studentdetail = context.Students.FirstOrDefault(e => e.Id == id);
                if (studentdetail != null)
                {
                    context.Students.Remove(studentdetail);
                    context.SaveChanges();
                }
                return studentdetail;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}
