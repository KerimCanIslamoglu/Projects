using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GotCoreApp.Models;
using Microsoft.EntityFrameworkCore;
using PagedList.Mvc;
using PagedList;
using ReflectionIT.Mvc.Paging;
using Microsoft.AspNetCore.Routing;


namespace GotCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private GotDbConsoleContext context;

        public HomeController(GotDbConsoleContext _context)
        {
            context = _context;
        }

        public async Task<IActionResult> Index(string filter, int page = 1, string SortByTitle = "Id")
        {
            var episodes = context.Bolumlers.AsNoTracking().Include(x => x.Ratings).AsQueryable();

            if (!string.IsNullOrWhiteSpace(filter))
            {
                if (filter.Length == 1)
                {
                    episodes = episodes.Where(x => x.Season.Contains(filter));
                }
                else
                {
                    episodes = episodes.Where(x => x.Title.Contains(filter) || x.Released.Contains(filter));
                }
            }

            var model = await PagingList.CreateAsync(episodes, 15, page, SortByTitle, "Id");

            model.RouteValue = new RouteValueDictionary
            {
                { "filter",filter }

            };
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = context.Bolumlers.Include(x => x.Ratings).FirstOrDefault(x => x.Id == id);
            return View(model);
        }

       
    }
}
