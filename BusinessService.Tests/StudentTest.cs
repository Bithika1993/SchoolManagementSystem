using BusinessService.Api.Controllers;
using BusinessService.Data;
using BusinessService.Data.Repositories;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using BusinessService.Services;
using Microsoft.AspNetCore.Mvc;
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
            var Respond = controller.GetStudentWithAcademicDetails(2);
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }
        [Test]
        public void GetAllStudentPersonalInfo_Test()
        {
            var controller = new StudentController();
            var Respond = controller.GetAllStudentPersonalInfo();
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }
        [Test]
        public void GetAllStudentsDetails_Test()
        {
            var controller = new StudentController();
            var Respond = controller.GetAllStudentsDetails();
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }
        [Test]
        public void GetStudentsBySchoolId_Test()
        {
            var controller = new StudentController();
            var Respond = controller.GetStudentsBySchoolId(3);
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }
        [Test]
        public void AddStudent_Test()
        {
            Student studentdetails = new Student();
            studentdetails.Name = "john";
            studentdetails.DOB = "01-01-1995";
            studentdetails.Gender = "Male";
            studentdetails.CourseId = 1;
            studentdetails.SchoolId = 3;
            studentdetails.ClassId = 1;
            var controller = new StudentController();
            var Respond = controller.AddStudent(studentdetails);
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }
    }
}
