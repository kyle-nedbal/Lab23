using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab23.Data;
using Lab23.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lab22.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MoviesContext _dbContext;

        // GET: /<controller>/
        public MoviesController (MoviesContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var movies = _dbContext.Movies.ToList();
            return View(movies);
        }

        [HttpPost]
        public IActionResult SearchResultTitle(Movie model)
        {
            var movies = new List<Movie>();
            foreach (var item in _dbContext.Movies.ToList())
            {
                if (item.Title == model.Title)
                {
                    movies.Add(item);
                }
            }
            return View(movies);
        }

        [HttpPost]
        public IActionResult SearchResultGenre(Movie model)
        {
            var movies = new List<Movie>();
            foreach (var item in _dbContext.Movies.ToList())
            {
                if (item.Genre == model.Genre)
                {
                    movies.Add(item);
                }
            }
            return View(movies);
        }
    }
}