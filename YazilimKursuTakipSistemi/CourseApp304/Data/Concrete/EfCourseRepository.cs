using CourseApp304.Data.Abstract;
using CourseApp304.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp304.Data.Concrete
{
    public class EfCourseRepository : ICourseRepository
    {
        private DataContext context;
        public EfCourseRepository(DataContext _context)
        {
            context = _context;
        }
        public IQueryable<Course> Courses => context.Courses;

        public int CreateCourse(Course newCourse)
        {
            context.Courses.Add(newCourse);
            context.SaveChanges();
            return newCourse.Id;
        }

        public void DeleteCourse(int courseid)
        {
            context.Courses.Remove(new Course() { Id = courseid });
            context.SaveChanges();
        }

        public Course GetById(int courseid)
        {
            return context.Courses
                 .Include(x => x.Instructor)
                 .ThenInclude(x => x.Contact)
                 .ThenInclude(x => x.Address)
                 .FirstOrDefault(x => x.Id == courseid);

        }

        public IEnumerable<Course> GetCourseByFilters(string name = null, decimal? price = null, string isActive = null,string instructor=null)
        {
            IQueryable<Course> query = context.Courses.Include(x=>x.Instructor);
            if (name != null)
            {
                query = query.Where(x => x.CourseName.ToLower().Contains(name.ToLower()));//Büyük küçük harf duyarlılığını kaldırdık.
            }
            if (price != null)
            {
                query = query.Where(x => x.Price <= price);
            }
            if (isActive == "on")
            {
                query = query.Where(x => x.isActive == true);
            }
            if (instructor != null)
            {
                query = query.Where(x => x.Instructor.Name.ToLower().Contains(instructor.ToLower()));
            }
            return query.ToList();
        }

        public IEnumerable<Course> GetCourses()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesByActive(bool isActive)
        {
            return context.Courses.Where(x => x.isActive == isActive).ToList();
        }

        public void UpdateAll(int id, Course[] courses)
        {
            context.Courses.UpdateRange(courses.Where(x => x.InstructorId!=id));
            context.SaveChanges();
        }

        public void UpdateCourse(Course updateCourse, Course originalCourse = null)
        {
            if (originalCourse == null)
            {
                originalCourse = context.Courses.Find(updateCourse.Id);
            }
            else
            {
                context.Courses.Attach(originalCourse);
            }
            //Course
            originalCourse.CourseName = updateCourse.CourseName;
            originalCourse.Description = updateCourse.Description;
            originalCourse.Price = updateCourse.Price;
            originalCourse.isActive = updateCourse.isActive;
            //Instructor
            originalCourse.Instructor.Name = updateCourse.Instructor.Name;
            //Contact
            originalCourse.Instructor.Contact.Email = updateCourse.Instructor.Contact.Email;
            originalCourse.Instructor.Contact.Phone = updateCourse.Instructor.Contact.Phone;
            //Address
            originalCourse.Instructor.Contact.Address.City = updateCourse.Instructor.Contact.Address.City;
            originalCourse.Instructor.Contact.Address.Country = updateCourse.Instructor.Contact.Address.Country;
            originalCourse.Instructor.Contact.Address.Text = updateCourse.Instructor.Contact.Address.Text;


            EntityEntry courseEntry = context.Entry(originalCourse);
            EntityEntry instructorEntry = context.Entry(originalCourse.Instructor);
            EntityEntry contactEntry = context.Entry(originalCourse.Instructor.Contact);
            EntityEntry addressEntry = context.Entry(originalCourse.Instructor.Contact.Address);

            //Modified,Unchanged,Added,Deleted,Detached====> EntityEntryState

            Console.WriteLine($"Course EntityState:{courseEntry.State}");

            foreach (var property in new string[] { "CourseName", "Description", "Price", "isActive" })
            {
                Console.WriteLine($"{property}-old:{courseEntry.OriginalValues[property]} new:{courseEntry.CurrentValues[property]}");
            }
            Console.WriteLine($"Instructor EntityState:{instructorEntry.State}");
            foreach (var property in new string[] { "Name" })
            {
                Console.WriteLine($"{property}-old:{instructorEntry.OriginalValues[property]} new:{instructorEntry.CurrentValues[property]}");
            }
            Console.WriteLine($"Contact EntityState:{contactEntry.State}");
            foreach (var property in new string[] { "Email","Phone" })
            {
                Console.WriteLine($"{property}-old:{contactEntry.OriginalValues[property]} new:{contactEntry.CurrentValues[property]}");
            }
            Console.WriteLine($"Address EntityState:{addressEntry.State}");
            foreach (var property in new string[] { "City","Country","Text" })
            {
                Console.WriteLine($"{property}-old:{addressEntry.OriginalValues[property]} new:{addressEntry.CurrentValues[property]}");
            }

            context.SaveChanges();

        }
    }
}
