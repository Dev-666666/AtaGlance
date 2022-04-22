using SampleWebApi.Model;
using System.Collections.Generic;

namespace SampleWebApi.Repositories
{
    public interface IEmpRepo
    {
        string AddEmp(Employee employee);
        string Delete(int id);
        IEnumerable<Employee> GetEmpData();
        string Modify(Employee employee);
    }
}
