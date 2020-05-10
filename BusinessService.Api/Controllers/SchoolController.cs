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
    public class SchoolController : ControllerBase
    {
        private readonly HttpResponses response = new HttpResponses();
        private readonly ISchoolRepository _schoolRepository;
        public SchoolController(ISchoolRepository schoolRepository)
        {
            this._schoolRepository = schoolRepository;
        }
        [HttpGet]
        [Route("GetSchool/{id}")]
        public IActionResult GetSchool(int id)
        {
            try
            {
                var school = _schoolRepository.Get(id);
                if (school != null)
                {                   
                    return Ok(school);
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
        [Route("getAllSchool")]
        public IActionResult GetAllSchool()
        {
            try
            {
                var schoollist = _schoolRepository.GetAll();

                if (schoollist.Any())
                {
                    return Ok(schoollist);
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
        [Route("addSchool")]
        public IActionResult Post([FromBody]School school)
        {
            try
            {
               _schoolRepository.Add(school);
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
        [Route("updateSchool/{id}")]
        public IActionResult UpdateSchool(int id,[FromBody]School school)
        {
            try
            {
                _schoolRepository.Update(id, school);
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
        [Route("deleteSchool/{id}")]
        public IActionResult DeleteSchool(int id)
        { 
            try
            {
               _schoolRepository.Delete(id);
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