using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CourseApp304.Data.Abstract;
using CourseApp304.Data.Concrete;
using CourseApp304.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CourseApp304.Controllers
{
    public class StudentController : Controller
    {
       // private DataContext context;
        private IStudentRepository repo;
        private IGenericRepository<Student> repository;
     
        public StudentController(IStudentRepository _repo, IGenericRepository<Student> _repository)
        {            
            repository = _repository;
            repo = _repo;
        }

        public IActionResult Index()
        {
            return View(repo.GetStudents());
        }
        public IActionResult Create()
        {
            return View("StudentEditor");
        }
       
        public IActionResult Edit(int id)
        {         
            return View("StudentEditor", repo.GetStudents().FirstOrDefault(x=>x.Id==id));
           // return View("StudentEditor",context.Students.Include(x=>x.Address).FirstOrDefault(x=>x.Id==id));
        }
       
        [HttpPost]
        public IActionResult Edit(Student entity)
        {
            if (entity.Id==0)
            {
                //context.Students.Add(entity);
                repository.Insert(entity);
            }
            else
            {
                //context.Students.Update(entity);                
                repository.Update(entity);
            }
            //context.SaveChanges();
            return RedirectToAction("Index");            
        }
        public IActionResult Delete(int id)
        {
            repository.Delete(id);
            return RedirectToAction("Index");
        }

    }
}