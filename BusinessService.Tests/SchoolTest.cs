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
    public class SchoolTest
    {
        ISchoolRepository schoolRepository;
        public SchoolTest()
        {
            schoolRepository = new SchoolService();
        }
        [Test]
        public void GetSchool_Test()
        {
            var controller = new SchoolController(schoolRepository);
            var result = controller.Get(1);
            //Assert.AreEqual(1, result.Count());
        }
        [Test]
        public void GetAllStudent_Test()
        {
            var controller = new SchoolController(schoolRepository);
            var result = controller.GetAllStudent();
            Assert.AreEqual(1, result.Count());
        }
        [Test]
        public void AddSchool_Test()
        {
            School schooldetails = new School();
            schooldetails.SchoolName = "abc";
            schooldetails.SchoolType = "xyz";
            schooldetails.Country = "India";
            schooldetails.City = "Kolkata";
            Course course = new Course() { CourseId = 1 };
            var controller = new SchoolController(schoolRepository);
            var result = controller.Post(schooldetails);
            Assert.AreEqual(null, result);
        }
    }
}
