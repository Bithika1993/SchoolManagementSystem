using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using BusinessService.Domain.Model;
using BusinessService.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BusinessService.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        [HttpGet]
        [Route("GetStudent/{id}")]
        public IActionResult GetStudent(int id)
        {
            try
            {
                var student = _studentRepository.GetStudent(id);

                if (student != null)
                {
                    return Ok(student);
                }
                else
                {
                    return NotFound(" Student Not Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("getAllStudent")]
        public IActionResult GetAllStudent()
        {
            try
            {
                var studentlist = _studentRepository.GetAllStudent();

                if (studentlist.Count() > 0)
                {
                    return Ok(studentlist);
                }
                else
                {
                    return NotFound(" StudentList Not Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("getAllStudents")]
        public IActionResult GetAllStudents()
        {
            try
            {
                var studentlist = _studentRepository.GetAllStudents();

                if (studentlist.Count() > 0)
                {
                    return Ok(studentlist);
                }
                else
                {
                    return NotFound(" StudentList Not Found");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        [Route("addStudent")]
        public IActionResult AddStudent([FromBody]Student student)
        {
            try
            {
               var result=_studentRepository.Add(student);
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
        [Route("updateStudent/{id}")]
        public IActionResult UpdateStudent(int id, [FromBody]Student student)
        {          
            try
            {
               var result= _studentRepository.Update(id, student);
                if(result!=null)
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
        [Route("deleteStudent/{id}")]
        public IActionResult DeleteStudent(int id)
        {           
            try
            {
               var result= _studentRepository.Delete(id);
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