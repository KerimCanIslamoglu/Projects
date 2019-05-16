using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ImdbCore.Models;
using ImdbCore.Data.Concrete.EfCore;
using System.Net;
using System.IO;

namespace ImdbCore.Controllers
{
    public class HomeController : Controller
    {
        private DataContext context;
        public HomeController(DataContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Movie(KeyWords model)
        {
            context.KeyWords.RemoveRange(context.KeyWords);
            context.KeyWords.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index","Movie");
        }

        [HttpPost]
        public IActionResult Serie(KeyWords model)
        {
            context.KeyWords.RemoveRange(context.KeyWords);
            context.KeyWords.Add(model);
            context.SaveChanges();
            return RedirectToAction("Index", "Serie");
        }

      
    }
}
