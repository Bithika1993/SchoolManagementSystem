using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using BusinessService.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinessService.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClassController : ControllerBase
    {
        private readonly IClassRepository _classRepository;
        public ClassController()
        {
            _classRepository = new ClassService();
        }
        [HttpGet]
        [Route("GetClass/{id}")]
        public IActionResult GetClass(int id)
        {
            try
            {
                var classes = _classRepository.Get(id);

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
                var classtlist = _classRepository.GetAll();

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
        public IActionResult AddClass([FromBody]Class entities)
        {
            try
            {
                _classRepository.Add(entities);
                return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        [Route("updateClass/{id}")]
        public IActionResult UpdateClass(int id, [FromBody]Class entities)
        { 
            try
            { 
                _classRepository.Update(id, entities);
                return Ok("Success");
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
               _classRepository.Delete(id);
               return Ok("Success");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}