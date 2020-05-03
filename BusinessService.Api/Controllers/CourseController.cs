﻿using System;
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
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;
        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        [HttpGet]
        [Route("GetCourse/{id}")]
        public IActionResult GetCourse(int id)
        {
            try
            {
                var course = _courseRepository.GetCourse(id);

                if (course != null)
                {
                    return Ok(course);
                }
                else
                {
                    return NotFound(" Course Not Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("getAllCourse")]
        public IActionResult GetAllCourse()
        {
            try
            {
                var coursetlist = _courseRepository.GetAllCourse();

                if (coursetlist.Count() > 0)
                {
                    return Ok(coursetlist);
                }
                else
                {
                    return NotFound(" CourseList Not Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPost]
        [Route("addCourse")]
        public IActionResult AddCourse([FromBody]Course course)
        {
            try
            {
               var result= _courseRepository.Add(course);
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
        [Route("updateCourse/{id}")]
        public IActionResult UpdateCourse(int id, [FromBody]Course course)
        {
            try
            {
                var result=_courseRepository.Update(id, course);
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
        [Route("deleteCourse/{id}")]
        public IActionResult DeleteCourse(int id)
        {
            try
            {
                _courseRepository.Delete(id);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}