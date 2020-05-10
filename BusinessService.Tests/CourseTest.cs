using BusinessService.Api.Controllers;
using BusinessService.Domain.Services;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace BusinessService.Tests
{
    [TestFixture]
    public class CourseTest
    {
        private readonly CourseController _courseController;
        private readonly ICourseRepository _courseRepository;
        public CourseTest()
        {
            _courseRepository = new CourseService();
            _courseController = new CourseController(_courseRepository);
        }
        [Test]
        public void GetCourse_Test()
        {
            var Respond = _courseController.GetCourse(2);
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);

        }
        [Test]
        public void GetAllSchool_Test()
        {
            var Respond = _courseController.GetAllCourse();
            var Result = Respond as OkObjectResult;
            Assert.AreEqual(200, Result.StatusCode);
        }

    }
}
