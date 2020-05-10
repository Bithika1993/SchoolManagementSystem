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
    public class ClassController : ControllerBase
    {
        private readonly HttpResponses responses = new HttpResponses();
        private readonly IClassRepository _classRepository;
        public ClassController(IClassRepository classRepository)
        {
            this._classRepository = classRepository;
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
                    var Respond = NotFound();
                    responses.StatusCode = Respond.StatusCode;
                    responses.Message = Constants.NotFound;
                    return NotFound(responses);
                }
            }
            catch (Exception)
            {
                var Respond = BadRequest();
                responses.StatusCode = Respond.StatusCode;
                responses.Message = Constants.Failure;
                return BadRequest(responses);
            }

        }
        [HttpGet]
        [Route("getAllClass")]
        public IActionResult GetAllClass()
        {
            try
            {
                var classtlist = _classRepository.GetAll();

                if (classtlist.Any())
                {
                    return Ok(classtlist);
                }
                else
                {
                    var Respond = NotFound();
                    responses.StatusCode = Respond.StatusCode;
                    responses.Message = Constants.NotFound;
                    return NotFound(responses);
                }
            }
            catch (Exception)
            {
                var Respond = BadRequest();
                responses.StatusCode = Respond.StatusCode;
                responses.Message = Constants.Failure;
                return BadRequest(responses);
            }

        }
        [HttpPost]
        [Route("addClass")]
        public IActionResult AddClass([FromBody]Class entities)
        {
            try
            {
                _classRepository.Add(entities);
                var Respond = Ok();
                responses.StatusCode = Respond.StatusCode;
                responses.Message = Constants.Success;
                return Ok(responses);
            }
            catch (Exception)
            {
                var Respond = BadRequest();
                responses.StatusCode = Respond.StatusCode;
                responses.Message = Constants.Failure;
                return BadRequest(responses);
            }
        }
        [HttpPut]
        [Route("updateClass/{id}")]
        public IActionResult UpdateClass(int id, [FromBody]Class entities)
        { 
            try
            { 
                _classRepository.Update(id, entities);
                var Respond = Ok();
                responses.StatusCode = Respond.StatusCode;
                responses.Message = Constants.Success;
                return Ok(responses);
            }
            catch(Exception)
            {
                var Respond = BadRequest();
                responses.StatusCode = Respond.StatusCode;
                responses.Message = Constants.Failure;
                return BadRequest(responses);
            }
        }
        [HttpDelete]
        [Route("deleteClass/{id}")]
        public IActionResult DeleteClass(int id)
        {          
            try
            {
               _classRepository.Delete(id);
                var Respond = Ok();
                responses.StatusCode = Respond.StatusCode;
                responses.Message = Constants.Success;
                return Ok(responses);
            }
            catch (Exception)
            {
                var Respond = BadRequest();
                responses.StatusCode = Respond.StatusCode;
                responses.Message = Constants.Failure;
                return BadRequest(responses);
            }
        }
    }
}