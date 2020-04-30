using BusinessService.Api.Controllers;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using BusinessService.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessService.Tests
{
    [TestFixture]
    public class StudentTest
    {
        IStudentRepository studentRepository;
        
        public StudentTest()
        {
             studentRepository = new StudentService();
        }
        [Test]
        public void GetStudent_Test()
        {
            var controller = new StudentController(studentRepository);
            var result = controller.Get(2);
            //Assert.AreEqual(1, result.Count());
        }
        [Test]
        public void GetAllStudent_Test()
        {
            var controller = new StudentController(studentRepository);
            var result=controller.GetAllStudent();
            Assert.AreEqual(1,result.Count());
        }
        [Test]
        public void GetAllStudents_Test()
        {
            var controller = new StudentController(studentRepository);
            var result = controller.GetAllStudents();
            Assert.AreEqual(1, result.Count());
        }
        [Test]
        public void AddStudent_Test()
        {
            Student studentdetails = new Student();
            studentdetails.Name = "Priyanka2";
            studentdetails.DOB = "01-01-2019";
            studentdetails.Gender = "Female";
            studentdetails.CourseId = 1;
            studentdetails.SchoolId = 1;
            var controller = new StudentController(studentRepository);
            var result = controller.Post(studentdetails);
            Assert.AreEqual(null, result);
        }
    }
}
