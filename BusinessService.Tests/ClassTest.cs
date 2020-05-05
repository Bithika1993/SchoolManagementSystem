using BusinessService.Api.Controllers;
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
    public class ClassTest
    { 
        [Test]
        public void GetClass_Test()
        {
            var controller = new ClassController();
            var Respond = controller.GetClass(1);
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }
        [Test]
        public void GetAllClass_Test()
        {
            var controller = new ClassController();
            var Respond = controller.GetAllClass();
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }
        [Test]
        public void AddClass_Test()
        {
            Class classdetails = new Class();
            classdetails.ClassName = "class-1";
            classdetails.Description = "abc";
            var controller = new ClassController();
            var Respond = controller.AddClass(classdetails);
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }
        [Test]
        public void UpdateClass_Test()
        {
            Class classdetails = new Class();
            classdetails.ClassId = 1;
            classdetails.ClassName = "class-10";
            classdetails.Description = "class-10";
            var controller = new ClassController();
            var Respond = controller.UpdateClass(classdetails.ClassId,classdetails);
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }
    }
}
