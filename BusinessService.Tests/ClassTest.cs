using BusinessService.Api.Controllers;
using BusinessService.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace BusinessService.Tests
{
    public class ClassTest
    {
        private readonly ClassController _classController;
        private readonly IClassRepository _classRepository;
        public ClassTest()
        {
            _classRepository = new ClassService();
            _classController = new ClassController(_classRepository);
        }
        [Test]
        public void GetClass_Test()
        {
            var Respond = _classController.GetClass(2);
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);

        }
        [Test]
        public void GetAllSchool_Test()
        {
            var Respond = _classController.GetAllClass();
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }

    }
}
