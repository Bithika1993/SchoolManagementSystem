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
    public class ClassTest
    { 
        [Test]
        public void GetClass_Test()
        {
            var controller = new ClassController();
            var result = controller.GetClass(1);
            //Assert.AreEqual(1, result.Count());
        }
        [Test]
        public void GetAllClass_Test()
        {
            var controller = new ClassController();
            var result = controller.GetAllClass();
           // Assert.AreEqual(1, result.Count());
        }
        [Test]
        public void AddClass_Test()
        {
            Class classdetails = new Class();
            classdetails.ClassName = "class-1";
            classdetails.Description = "abc";
            var controller = new ClassController();
            var result = controller.AddClass(classdetails);
            Assert.AreEqual(null, result);
        }
    }
}
