using BusinessService.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessService.Data.Repositories
{
    public class SqlStudentRepository
    {
         BusinessServiceDbContext context= new BusinessServiceDbContext();
        //public List<Student> studentlist = new List<Student>();
        //private List<Student> _studentList;
        //public SqlStudentRepository(BusinessServiceDbContext context)
        //{
        //    this.context = context;
        //}
        //public SqlStudentRepository()
        //{
        //    _studentList = new List<Student>()
        //    {
        //        new Student(){Id=1, Name="Bithika" ,DOB="01-01-2019",Gender="F" },
        //        new Student(){Id=2, Name="Bithika1" ,DOB="01-01-2019",Gender="F" },
        //        new Student(){Id=3, Name="Bithika" ,DOB="01-01-2019",Gender="F" }

        //    };
        //}
        public Student GetStudent(int id)
        {
            var studentdetails = context.Students.FirstOrDefault(e => e.Id == id);
            return studentdetails;
        }
        public IEnumerable<Student> GetAllStudent()
        {
            var studentList = context.Students.ToList();
            return studentList;
             
        }
        public Student Add(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return null;
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
