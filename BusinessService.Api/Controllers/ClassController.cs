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
    [ApiController]
    [Route("api/[controller]")]
    public class ClassController : ControllerBase
    {
        private readonly IClassRepository _classRepository;
        public ClassController(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        [HttpGet]
        [Route("GetClass/{id}")]
        public IActionResult GetClass(int id)
        {
            try
            {
                var classes = _classRepository.Getclass(id);

                if (classes != null)
                {
                    return Ok(classes);
                }
                else
                {
                    return NotFound(" Class Not Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("getAllClass")]
        public IActionResult GetAllClass()
        {
            try
            {
                var classtlist = _classRepository.GetAllClass();

                if (classtlist.Count() > 0)
                {
                    return Ok(classtlist);
                }
                else
                {
                    return NotFound(" ClassList Not Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpPost]
        [Route("addClass")]
        public IActionResult AddClass([FromBody]Class cls)
        {
            try
            {
               var result= _classRepository.Add(cls);
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
        [Route("updateClass/{id}")]
        public IActionResult UpdateClass(int id, [FromBody]Class cls)
        { 
            try
            { 
                var result=_classRepository.Update(id, cls);
                if (result != null)
                    return Ok("Success");
                else
                    return NotFound("Failed!");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        [Route("deleteClass/{id}")]
        public IActionResult DeleteClass(int id)
        {          
            try
            {
               var result= _classRepository.Delete(id);
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