using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinessService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;
        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public Course Get(int id)
        {
            var course = _courseRepository.GetCourse(id);
            return course;

        }
        public IEnumerable<Course> GetAllStudent()
        {
            var coursetlist = _courseRepository.GetAllCourse();
            return coursetlist;

        }
        public HttpResponseMessage Post(Course course)
        {
            try
            {
                _courseRepository.Add(course);
                return null;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public HttpResponseMessage Put(int id, Course course)
        {
            _courseRepository.Update(id, course);
            return null;
        }
        public void Delete(int id)
        {
            _courseRepository.Delete(id);
        }

    }
}