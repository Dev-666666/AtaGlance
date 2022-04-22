using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleWebApi.Entities;
using SampleWebApi.Model;
namespace SampleWebApi.Repositories
{
    public class EmpRepo : IEmpRepo
    {
        RepositoriesContext con;
        public EmpRepo(RepositoriesContext context)
        {
            con = context;
        }
        public string AddEmp(Employee employee)
        {
            con.Employees.Add(employee);
            con.SaveChanges();
            return "Data Savaed";
        }

        public string Delete(int id)
        {
            var del = con.Employees.Where(p => p.Id == id).SingleOrDefault();
            if(del != null)
            {
                con.Employees.Remove(del);
                con.SaveChanges();
                return "Record Removed";
            }
            else { return "Try Again"; }
        }

        public IEnumerable<Employee> GetEmpData()
        {
            return con.Employees.ToList();
        }

        public string Modify(Employee employee)
        {
            var mod = con.Employees.Where(p => p.Id == employee.Id).SingleOrDefault();
            if(mod != null)
            {
                mod.Name = employee.Name;
                mod.Salary = employee.Salary;
                mod.Designation = employee.Designation;
                con.SaveChanges();
                return "Data Changed";
            }
            else { return "Try again"; }
        }
    }
}
