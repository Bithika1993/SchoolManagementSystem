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
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolRepository _schoolRepository;
        public SchoolController(ISchoolRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;
        }
        public School Get(int id)
        {
            var school = _schoolRepository.GetSchool(id);
            return school;

        }
        public IEnumerable<School> GetAllStudent()
        {
            var schoollist = _schoolRepository.GetAllSchool();
            return schoollist;

        }
        public HttpResponseMessage Post(School school)
        {
            try
            {
                _schoolRepository.Add(school);
                return null;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public HttpResponseMessage Put(int id, School school)
        {
            _schoolRepository.Update(id, school);
            return null;
        }
        public void Delete(int id)
        {
            _schoolRepository.Delete(id);
        }
    }
}