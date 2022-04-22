using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleWebApi.Controllers;
using SampleWebApi.Model;

namespace SampleWebApi.Services
{
    public interface IEmpServices
    {
        IEnumerable<Employee> GetEmpData();
        public string AddEmp(Employee employee);
        public string Modify(Employee employee);
        public string Delete(int id);
    }
}
