using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using SampleWebApi.Model;
using SampleWebApi.Repositories;
namespace SampleWebApi.Services
{
    public class StudentService :IStudentService
    {
        public readonly IStudentRepo studentRepo;
        public StudentService(IStudentRepo studentRepo)
        {
            this.studentRepo = studentRepo;
        }

        public string AddData(Student student)
        {
            return studentRepo.AddData(student);
        }

        public string Delete(int id)
        {
            return studentRepo.Delete(id);
        }

        public IEnumerable<Student> GetAllInfo()
        {
            return studentRepo.GetAllInfo();
        }

        public string Modify(Student student)
        {
            return studentRepo.Modify(student);
        }
    }
}
