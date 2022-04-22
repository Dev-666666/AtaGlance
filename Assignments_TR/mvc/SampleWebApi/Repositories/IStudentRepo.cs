using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SampleWebApi.Model;

namespace SampleWebApi.Repositories
{
    public interface IStudentRepo
    {
        IEnumerable<Student> GetAllInfo();
        string AddData(Student student);
        string Modify(Student student);
        string Delete(int id);
    }
}
