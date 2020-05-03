using BusinessService.Api.Controllers;
using BusinessService.Data;
using BusinessService.Data.Repositories;
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
        [Test]
        public void GetStudent_Test()
        {
            var controller = new StudentController();
            var result = controller.GetStudent(6);
            //Assert.AreEqual(1, result.Count());
        }
        [Test]
        public void GetAllStudent_Test()
        {
            var controller = new StudentController();
            var result=controller.GetAllStudent();
           // Assert.AreEqual(1,result.Count());
        }
        [Test]
        public void GetAllStudents_Test()
        {
            var controller = new StudentController();
            var result = controller.GetAllStudents();
            //Assert.AreEqual(1, result.Count());
        }
        [Test]
        public void AddStudent_Test()
        {
            Student studentdetails = new Student();
            studentdetails.Name = "john";
            studentdetails.DOB = "01-01-2019";
            studentdetails.Gender = "Male";
            studentdetails.CourseId = 2;
            studentdetails.SchoolId = 2;
            var controller = new StudentController();
            var result = controller.AddStudent(studentdetails);
            Assert.AreEqual(null, result);
        }
    }
}
