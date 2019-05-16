using CourseApp304.Data.Abstract;
using CourseApp304.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp304.Data.Concrete
{
    public class StudentRepository : IStudentRepository
    {
        private DataContext context;
        public StudentRepository(DataContext _context)
        {
            context = _context;   
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
            return context.Students.Include(x => x.Address).ToList();
        }

        public void Insert(Student entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
