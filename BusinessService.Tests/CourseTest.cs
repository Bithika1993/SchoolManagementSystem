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
    public class CourseTest
    {
        [Test]
        public void GetCourse_Test()
        {
            var controller = new CourseController();
            var Respond = controller.GetCourse(1);
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }
        [Test]
        public void GetAllCourse_Test()
        {
            var controller = new CourseController();
            var Respond = controller.GetAllCourse();
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }
        [Test]
        public void AddCourse_Test()
        {
            Course coursedetails = new Course();
            coursedetails.CourseName = "Science";
            coursedetails.Description= "abc";
            var controller = new CourseController();
            var Respond = controller.AddCourse(coursedetails);
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }
    }
}
