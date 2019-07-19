using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FullStackMVC5.Models;
using FullStackMVC5.ViewModels;
using System.Data.Entity;

namespace FullStackMVC5.Controllers
{
    public class MoviesController : Controller
    {

        public ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();    
        }

        // GET: Movies/Index
        public ActionResult Index()
        {

            var movies = _context.Movies.Include(c => c.MovieGenre).ToList();


            return View(movies);
        }


        //GET: Movies/Random
        public ActionResult Random()
        {
            var customers = _context.Customers.ToList();

            var viewModel = new RandomMovieViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Details(int id)
        {

            var movie = _context.Movies.Include(m => m.MovieGenre).SingleOrDefault(c => c.Id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }
    }
}