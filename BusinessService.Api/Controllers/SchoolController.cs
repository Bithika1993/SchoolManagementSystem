using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace BusinessService.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolRepository _schoolRepository;
        public SchoolController(ISchoolRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;
        }
        [HttpGet]
        [Route("GetSchool/{id}")]
        public IActionResult GetSchool(int id)
        {
            try
            {
                var school = _schoolRepository.GetSchool(id);

                if (school != null)
                {
                    return Ok(school);
                }
                else
                {
                    return NotFound(" School Not Found");
                }
            }
            catch (Exception ex)
            { 
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("getAllSchool")]
        public IActionResult GetAllSchool()
        {
            try
            {
                var schoollist = _schoolRepository.GetAllSchool();

                if (schoollist.Count() > 0)
                {
                    return Ok(schoollist);
                }
                else
                {
                    return NotFound(" SchoolList Not Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("addSchool")]
        public IActionResult Post([FromBody]School school)
        {
            try
            {
               var result= _schoolRepository.Add(school);
                if (result != null)
                    return Ok("Success");
                else
                    return NotFound("Failed!");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("updateSchool/{id}")]
        public IActionResult UpdateSchool(int id,[FromBody]School school)
        {
            try
            {
                var result=_schoolRepository.Update(id, school);
                if (result != null)
                    return Ok("Success");
                else
                    return NotFound("Failed!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("deleteSchool/{id}")]
        public IActionResult DeleteSchool(int id)
        { 
            try
            {
               var result= _schoolRepository.Delete(id);
                if (result != null)
                    return Ok("Success");
                else
                    return NotFound("Failed!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}