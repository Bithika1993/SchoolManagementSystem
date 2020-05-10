using BusinessService.Api.Controllers;
using BusinessService.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;


namespace BusinessService.Tests
{
    public class SchoolTest
    {
        private readonly SchoolController _schoolController;
        private readonly ISchoolRepository _schoolRepository;
        public SchoolTest()
        {
            _schoolRepository = new SchoolService();
            _schoolController = new SchoolController(_schoolRepository);
        }
        [Test]
        public void GetSchool_Test()
        {
            var Respond = _schoolController.GetSchool(2);
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);

        }
        [Test]
        public void GetAllSchool_Test()
        {
            var Respond = _schoolController.GetAllSchool();
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }
      
    }
}
