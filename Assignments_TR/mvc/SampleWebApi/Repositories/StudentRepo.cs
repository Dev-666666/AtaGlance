using System;
using System.Collections.Generic;
using System.Linq;
using SampleWebApi.Model;
using SampleWebApi.Entities;
using System.Threading.Tasks;
namespace SampleWebApi.Repositories
{
    public class StudentRepo :IStudentRepo
    {
        RepositoriesContext context;
        public StudentRepo(RepositoriesContext context)
        {
            this.context = context;
        }

        public string AddData(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
            return "Data Added";
        }

        public string Delete(int id)
        {
            var stud = context.Students.Where(p => p.Id == id).SingleOrDefault();
            if(stud != null)
            {
                context.Students.Remove(stud);
                context.SaveChanges();
                return "Deleted";
            }
            else { return "Cant remove Data"; }
        }

        public IEnumerable<Student> GetAllInfo()
        {
            return context.Students.ToList();
        }

        public string Modify(Student student)
        {
            var stud= context.Students.Where(p => p.Id == student.Id).SingleOrDefault();
            if(stud != null)
            {
                stud.Name = student.Name;
                stud.Percentage = student.Percentage;
                context.SaveChanges();
                return "DataSavedSuccessfully";
            }
            else
            {
                return "failed";
            }
        }
    }
}
