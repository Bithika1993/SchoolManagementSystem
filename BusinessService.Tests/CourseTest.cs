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
    public class CourseTest
    {
        ICourseRepository courseRepository;

        public CourseTest()
        {
            courseRepository = new CourseService();
        }
        [Test]
        public void GetStudent_Test()
        {
            var controller = new CourseController(courseRepository);
            var result = controller.Get(1);
            //Assert.AreEqual(1, result.Count());
        }
        [Test]
        public void GetAllStudent_Test()
        {
            var controller = new CourseController(courseRepository);
            var result = controller.GetAllStudent();
            Assert.AreEqual(1, result.Count());
        }
        [Test]
        public void AddStudent_Test()
        {
            Course coursedetails = new Course();
            coursedetails.CourseName = "commerce";
            coursedetails.Description= "abc";
            var controller = new CourseController(courseRepository);
            var result = controller.Post(coursedetails);
            Assert.AreEqual(null, result);
        }
    }
}
