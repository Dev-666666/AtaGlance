using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using SampleWebApi.Repositories;
using SampleWebApi.Model;

namespace SampleWebApi.Services
{
    public class EmpService : IEmpServices
    {
        public readonly IEmpRepo empRepo;
        public EmpService(IEmpRepo empRepo)
        {
            this.empRepo = empRepo;
        }
        public string AddEmp(Employee employee)
        {
            return empRepo.AddEmp(employee);
        }

        public string Delete(int id)
        {
            return empRepo.Delete(id);
        }

        public IEnumerable<Employee> GetEmpData()
        {
            return empRepo.GetEmpData();
        }

        public string Modify(Employee employee)
        {
            return empRepo.Modify(employee);
        }
    }
}
