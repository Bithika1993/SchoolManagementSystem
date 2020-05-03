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
    public class CourseTest
    {
        [Test]
        public void GetStudent_Test()
        {
            var controller = new CourseController();
            var result = controller.GetAllCourse();
            //Assert.AreEqual(1, result.Count());
        }
        [Test]
        public void GetAllCourse_Test()
        {
            var controller = new CourseController();
            var result = controller.GetAllCourse();
           // Assert.AreEqual(1, result.Count());
        }
        [Test]
        public void AddCourse_Test()
        {
            Course coursedetails = new Course();
            coursedetails.CourseName = "Science";
            coursedetails.Description= "abc";
            var controller = new CourseController();
            var result = controller.AddCourse(coursedetails);
            Assert.AreEqual(null, result);
        }
    }
}
