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
    public class SchoolTest
    {
        
        [Test]
        public void GetSchool_Test()
        {
            var controller = new SchoolController();
            var Respond = controller.GetSchool(1);
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }
        [Test]
        public void GetAllSchool_Test()
        {
            var controller = new SchoolController();
            var Respond = controller.GetAllSchool();
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }
        [Test]
        public void AddSchool_Test()
        {
            School schooldetails = new School();
            schooldetails.SchoolName = "abcd";
            schooldetails.SchoolType = "xyz";
            schooldetails.Country = "India";
            schooldetails.City = "Kolkata";
            var controller = new SchoolController();
            var Respond = controller.Post(schooldetails);
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }
    }
}
