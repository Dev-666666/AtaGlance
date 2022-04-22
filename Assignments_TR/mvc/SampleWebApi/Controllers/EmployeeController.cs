using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SampleWebApi.Services;
using SampleWebApi.Model;

namespace SampleWebApi.Controllers
{
    //[Route("api/[controller]")]
    [Route("Employee")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmpServices empServices;

        public EmployeeController(IEmpServices empServices)
        {
            this.empServices = empServices;
        }
        [HttpGet]
        [Route("Get Employee Information")]

        public IActionResult GetData()
        {
            return new ObjectResult(empServices.GetEmpData());
        }
        [HttpPost]
        [Route("Add Employee")]
        public IActionResult AddEmp(Employee employee)
        {
            return new ObjectResult(empServices.AddEmp(employee));
        }
        [HttpPost]
        [Route("Modify Data")]
        public IActionResult Modify(Employee employee)
        {
            return new ObjectResult(empServices.Modify(employee));
        }

        [HttpPost]
        [Route("Delet Employee")]
        public IActionResult Delete(int id)
        {
            return new ObjectResult(empServices.Delete(id));
        }


    }
}
