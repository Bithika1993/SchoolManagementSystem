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
            //var student = (from s in context.Set<Student>()
            //               join c in context.Set<Course>()
            //               on s.CourseId equals c.CourseId
            //               join school in context.Set<School>()
            //               on s.SchoolId equals school.Id
            //               where s.Id == id
            //               select new { c, s, school }).First();
            //var studentdetails = student.s;
            var studentdetails = context.Students.Where(e => e.Id == id)
                      .Include(c => c.course)
                      .Include(p => p.school)
                      .First();
            return studentdetails;
        }
        public IEnumerable<Student> GetAllStudent()
        {
            var studentList = context.Students.ToList();
            return studentList;            
        }
        public IEnumerable<Student> GetAllStudents()
        {         
            //var student = (from s in context.Set<Student>()
            //               join c in context.Set<Course>()
            //               on s.course.CourseId equals c.CourseId
            //               join school in context.Set<School>()
            //               on s.school.Id equals school.Id
            //               select new { c, s, school });
            var studentDetail = context.Students
                      .Include(c => c.course)
                      .Include(p => p.school)
                      .ToList();                      
            return studentDetail;
        }
        public Student Add(Student student)
        {
            try
            {
                context.Students.Add(student);
                context.SaveChanges();
                return null;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        public Student update(int id,Student student)
        {
            var studentdetail = context.Students.FirstOrDefault(e => e.Id == id);
            if (studentdetail!=null)
            {
                studentdetail.Id = student.Id;
                studentdetail.Name = student.Name;
                studentdetail.DOB = student.DOB;
                studentdetail.Gender = student.Gender;
                context.SaveChanges();
            }         
            return studentdetail;
        }
        public Student Delete(int id)
        {
            var studentdetail = context.Students.FirstOrDefault(e => e.Id == id);
            if (studentdetail != null)
            {
                context.Students.Remove(studentdetail);
                context.SaveChanges();
            }
            return studentdetail;
        }
    }
}
