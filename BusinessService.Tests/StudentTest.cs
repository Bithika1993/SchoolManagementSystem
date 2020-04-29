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
        public void GetAllStudent_Test()
        {
            var controller = new StudentController(studentRepository);
            var result=controller.GetAllStudent();
            Assert.AreEqual(1,result.Count());
        }
        [Test]
        public void AddStudent_Test()
        {
            Student studentdetails = new Student();
            studentdetails.Name = "Bithika";
            studentdetails.DOB = "01-01-2019";
            studentdetails.Gender = "Female";
            var controller = new StudentController(studentRepository);
            var result = controller.Post(studentdetails);
            Assert.AreEqual(null, result);
        }
    }
}
