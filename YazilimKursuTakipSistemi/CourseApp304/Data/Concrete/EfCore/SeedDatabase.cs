using CourseApp304.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp304.Models
{
    public class SeedDatabase
    {
        public static void Seed(DbContext context)
        {
            if (context.Database.GetPendingMigrations().Count() == 0) //   !context.Database.GetPendingMigrations().Any()
            {
                if (context is DataContext)
                {
                    DataContext _context = context as DataContext;

                    if (_context.Courses.Count() == 0)   //   !_context.Courses.Any()
                    {
                        _context.Courses.AddRange(Courses);
                    }
                    if (_context.Instructors.Count() == 0)
                    {
                        _context.Instructors.AddRange(Instructors);
                    }
                    if (!_context.Students.Any())
                    {
                        _context.Students.AddRange(Students);
                    }
                }
                if (context is UserContext)
                {
                    UserContext _context = context as UserContext;
                    if (_context.Users.Count() == 0)   //   !_context.Users.Any()
                    {
                        _context.Users.AddRange(Users);
                    }
                }
                context.SaveChanges();               
            }
        }
        private static Course[] Courses
        {
            get
            {
                Course[] courses = new Course[]
                {
                    new Course()
                    {
                        CourseName="Html",
                        Price=10,
                        Description="About Html",
                        isActive=true,
                        Instructor=Instructors[0]
                    },
                     new Course()
                    {
                        CourseName="Css",
                        Price=100,
                        Description="About Css",
                        isActive=true,
                        Instructor=Instructors[1]
                    },
                      new Course()
                    {
                        CourseName="Js",
                        Price=220,
                        Description="About Js",
                        isActive=false,
                        Instructor=Instructors[0]
                    },
                       new Course()
                    {
                        CourseName="NodeJs",
                        Price=440,
                        Description="About NodeJs",
                        isActive=true,
                        Instructor=Instructors[1]
                    },
                        new Course()
                    {
                        CourseName="Mvc",
                        Price=770,
                        Description="About Mvc",
                        isActive=false,
                        Instructor=Instructors[2]
                    }
                };
                return courses;
            }
        }
        private static Student[] Students
        {
            get
            {
                Student[] students = new Student[]
                {
                    new Student()
                    {
                       Name="Ali"
                      
                    },
                    new Student()
                    {
                       Name="Veli"                   
                    },
                    new Student()
                    {
                       Name="Selim"                   
                    },
                    new Student()
                    {
                       Name="Mert"                   
                    }
                  
                };
                return students;
            }
        }
        private static Instructor[] Instructors =
        {

            new Instructor()
            {
                Name="Kerim",Contact=new Contact(){Email="kerim@gmail.com",Phone="05343569696",Address=new Address{City="Adana",Country="TR",Text="Sahrayıcedit Mh." } },
               
           
            },
             new Instructor()
            {
                Name="Kerim Can",Contact=new Contact(){Email="kerim@gmail.com",Phone="05343569696",Address=new Address{City="Adana",Country="TR",Text="Mahfesığmaz Mh." } },
               
           
            },  new Instructor()
            {
                Name="Ali",Contact=new Contact(){Email="ali@gmail.com",Phone="05343369696",Address=new Address{City="İstanbul",Country="TR",Text="Sahrayıcedit Mh." } },
               
           
            },  new Instructor()
            {
                Name="Ahmet",Contact=new Contact(){Email="ahmet@gmail.com",Phone="05348549696",Address=new Address{City="Mersin",Country="TR",Text="Çilek Mh." } },
                
           
            },  new Instructor()
            {
                Name="Mehmet",Contact=new Contact(){Email="mehmet@gmail.com",Phone="0538534696",Address=new Address{City="Antalya",Country="TR",Text="Alanya Mh." } },
               
           
            },  new Instructor()
            {
                Name="Veli",Contact=new Contact(){Email="veli@gmail.com",Phone="053439842696",Address=new Address{City="Kocaeli",Country="TR",Text="Gebze Mh." } },
                
            }

        };
        private static User[] Users =
        {
            new User()
            {
                UserName="Kerim",
                Email="kerim@gmail.com",
                Password="12345",
                City="Mersin",
            },
            new User()
            {
                UserName="Ali",
                Email="ali@gmail.com",
                Password="123345",
                City="İstanbul",
            },
            new User()
            {
                UserName="Asel",
                Email="asel@gmail.com",
                Password="12345456",
                City="Adana",
            }
        };
    }
}
