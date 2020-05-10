using System;
using System.Linq;
using BusinessService.Domain;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace BusinessService.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly HttpResponses response = new HttpResponses();
        private readonly ICourseRepository _courseRepository;
        public CourseController(ICourseRepository courseRepository)
        {
            this._courseRepository = courseRepository;
        }
        [HttpGet]
        [Route("GetCourse/{id}")]
        public IActionResult GetCourse(int id)
        {
            try
            {
                var course = _courseRepository.Get(id);

                if (course != null)
                {
                    return Ok(course);
                }
                else
                {
                    var Respond = NotFound();
                    response.StatusCode = Respond.StatusCode;
                    response.Message = Constants.NotFound;
                    return NotFound(response);
                }
            }
            catch (Exception)
            {
                var Respond = BadRequest();
                response.StatusCode = Respond.StatusCode;
                response.Message = Constants.Failure;
                return BadRequest(response);
            }

        }
        [HttpGet]
        [Route("getAllCourse")]
        public IActionResult GetAllCourse()
        {
            try
            {
                var coursetlist = _courseRepository.GetAll();

                if (coursetlist.Any())
                {
                    return Ok(coursetlist);
                }
                else
                {
                    var Respond = NotFound();
                    response.StatusCode = Respond.StatusCode;
                    response.Message = Constants.NotFound;
                    return NotFound(response);
                }
            }
            catch (Exception)
            {
                var Respond = BadRequest();
                response.StatusCode = Respond.StatusCode;
                response.Message = Constants.Failure;
                return BadRequest(response);
            }

        }
        [HttpPost]
        [Route("addCourse")]
        public IActionResult AddCourse([FromBody]Course course)
        {
            try
            {
               _courseRepository.Add(course);
                var Respond = Ok();
                response.StatusCode = Respond.StatusCode;
                response.Message = Constants.Success;
                return Ok(response);
            }
            catch (Exception)
            {
                var Respond = BadRequest();
                response.StatusCode = Respond.StatusCode;
                response.Message = Constants.Failure;
                return BadRequest(response);
            }
        }
        [HttpPut]
        [Route("updateCourse/{id}")]
        public IActionResult UpdateCourse(int id, [FromBody]Course course)
        {
            try
            {
                _courseRepository.Update(id, course);
                var Respond = Ok();
                response.StatusCode = Respond.StatusCode;
                response.Message = Constants.Success;
                return Ok(response);
            }
            catch (Exception)
            {
                var Respond = BadRequest();
                response.StatusCode = Respond.StatusCode;
                response.Message = Constants.Failure;
                return BadRequest(response);
            }
        }
        [HttpDelete]
        [Route("deleteCourse/{id}")]
        public IActionResult DeleteCourse(int id)
        {
            try
            {
                _courseRepository.Delete(id);
                var Respond = Ok();
                response.StatusCode = Respond.StatusCode;
                response.Message = Constants.Success;
                return Ok(response);
            }
            catch (Exception)
            {
                var Respond = BadRequest();
                response.StatusCode = Respond.StatusCode;
                response.Message = Constants.Failure;
                return BadRequest(response);
            }
        }

    }
}