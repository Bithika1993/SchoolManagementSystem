using System;
using System.Linq;
using System.Threading.Tasks;
using BusinessService.Domain;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using BusinessService.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace BusinessService.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly HttpResponses response = new HttpResponses();
        private readonly ServiceBusSender _serviceBusSender = new ServiceBusSender();
        private readonly IStudentRepository _studentRepository;
        public StudentController(IDistributedCache cache)
        {
            _studentRepository = new StudentService(cache);
        }
        
        [HttpGet]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage()
        {
            await _serviceBusSender.SendMessage();
            return Ok();
        }
        [HttpGet]
        [Route("GetStudentWithAcademicDetails/{id}")]
        public IActionResult GetStudentWithAcademicDetails(int id)
        {
            try
            {
                var student = _studentRepository.Get(id);

                if (student != null)
                {
                    return Ok(student);
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
        [Route("GetAllStudentPersonalInfo")]
        public IActionResult GetAllStudentPersonalInfo()
        {
            try
            {
                var studentlist = _studentRepository.GetAll();

                if (studentlist.Any())
                {
                    return Ok(studentlist);
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
        [Route("GetAllStudentsDetails")]
        public IActionResult GetAllStudentsDetails()
        {
            try
            {
                var studentlist = _studentRepository.GetAllStudentsDetails();

                if (studentlist.Any())
                {
                    return Ok(studentlist);
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
        [Route("GetStudentsBySchoolId/{id}")]
        public IActionResult GetStudentsBySchoolId(int id)
        {
            try
            {
                var studentlist = _studentRepository.GetStudentsBySchoolId(id);

                if (studentlist.Any())
                {
                    return Ok(studentlist);
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
        [Route("addStudent")]
        public IActionResult AddStudent([FromBody]Student student)
        {
            
            try
            {
               _studentRepository.Add(student);
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
        [Route("updateStudent/{id}")]
        public IActionResult UpdateStudent(int id, [FromBody]Student student)
        {
            try
            {
               _studentRepository.Update(id, student);
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
        [Route("deleteStudent/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            try
            {
               _studentRepository.Delete(id);
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