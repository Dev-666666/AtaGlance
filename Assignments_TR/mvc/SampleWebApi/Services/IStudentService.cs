using System;
using System.Linq;
using System.Collections.Generic;
using SampleWebApi.Model;

namespace SampleWebApi.Services
{
    public interface IStudentService
    {
        IEnumerable<Student> GetAllInfo();
        string AddData(Student student);
        string Modify(Student student);

        string Delete(int id);
    }
}
