using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;
using SampleWebApi.Model;
using SampleWebApi.Services;
namespace SampleWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentController(IStudentService studservice)
        {
            studentService = studservice;
        }

        [HttpGet]
        [Route("[action]")]
      //  [Route("api/Student/GetStudData")]

        public IActionResult GetStudData()
        {
            return new ObjectResult(studentService.GetAllInfo());
        }
        [HttpPost]
        [Route("AddData")]
        public IActionResult AddData(Student student)
        {
            return new ObjectResult(studentService.AddData(student));
        }
        [HttpPost]
        [Route("ModifyData")]

        public IActionResult Modify(Student student)
        {
            return new ObjectResult(studentService.Modify(student));
        }

        [HttpGet]
        [Route("DeleteData")]
        public IActionResult Delete(int id)
        {
            return new ObjectResult(studentService.Delete(id));
        }
    }
}
