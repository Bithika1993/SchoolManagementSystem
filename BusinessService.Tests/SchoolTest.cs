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
            var result = controller.GetSchool(1);
            //Assert.AreEqual(1, result.Count());
        }
        [Test]
        public void GetAllSchool_Test()
        {
            var controller = new SchoolController(schoolRepository);
            var result = controller.GetAllSchool();
            //Assert.AreEqual(1, result.Count());
        }
        [Test]
        public void AddSchool_Test()
        {
            School schooldetails = new School();
            schooldetails.SchoolName = "abcd";
            schooldetails.SchoolType = "xyz";
            schooldetails.Country = "India";
            schooldetails.City = "Kolkata";
            var controller = new SchoolController(schoolRepository);
            var result = controller.Post(schooldetails);
            Assert.AreEqual(null, result);
        }
    }
}
