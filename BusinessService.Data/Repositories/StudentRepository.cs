using BusinessService.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BusinessService.Data.Repositories
{
    public class StudentRepository:Repository<Student>
    {
        private readonly BusinessServiceDbContext context= new BusinessServiceDbContext();  
        public Student GetStudentWithAcademicDetails(int id)
        {
                var studentdetails = context.Students.Where(e => e.Id == id)
                          .Include(c => c.classes)
                          .Include(p => p.course)
                          .Include(s => s.school)
                          .First();
                return studentdetails;
            
        }
        public IEnumerable<Student> GetAllStudentsDetails()
        {
            var studentDetail = context.Students
                          .Include(c => c.classes)
                          .Include(p => p.course)
                          .Include(s => s.school)
                          .ToList();
                return studentDetail;
        }
        public IEnumerable<Student> GetStudentsBySchoolId(int id)
        {
               var  studentDetail = context.Students.Where(e => e.SchoolId == id)
                                    .Include(c => c.classes)
                                    .Include(p => p.course)
                                    .ToList();
                return studentDetail;
        }
        public void update(int id,Student entities)
        {
                var studentdetail = context.Students.FirstOrDefault(e => e.Id == id);
                if (studentdetail != null)
                {
                    studentdetail.Id = entities.Id;
                    studentdetail.Name = entities.Name;
                    studentdetail.DOB = entities.DOB;
                    studentdetail.Gender = entities.Gender;
                    studentdetail.City = entities.City;
                    studentdetail.ClassId = entities.ClassId;
                    studentdetail.CourseId = entities.CourseId;
                    studentdetail.SchoolId = entities.SchoolId;
                    context.SaveChanges();
                }
        }
    }
}
