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
    public class ClassController : ControllerBase
    {
        private readonly IClassRepository _classRepository;
        public ClassController(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        public Class Get(int id)
        {
            var classes = _classRepository.Getclass(id);
            return classes;

        }
        public IEnumerable<Class> GetAllClasst()
        {
            var classtlist = _classRepository.GetAllClass();
            return classtlist;

        }
        public HttpResponseMessage Post(Class cls)
        {
            try
            {
                _classRepository.Add(cls);
                return null;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public HttpResponseMessage Put(int id, Class cls)
        {
            _classRepository.Update(id, cls);
            return null;
        }
        public void Delete(int id)
        {
            _classRepository.Delete(id);
        }
    }
}