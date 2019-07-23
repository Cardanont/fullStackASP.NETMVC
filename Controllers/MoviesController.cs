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

        public ActionResult New()
        {
            var movieGenres = _context.MovieGenres.ToList();
            var viewModel = new MovieFormViewModel
            {
                MovieGenres = movieGenres
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);

                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.MovieGenreId = movie.MovieGenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
            }

            _context.SaveChanges();

            return View("Index", "Movies");

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

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movie == null)
                return HttpNotFound();

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                MovieGenres = _context.MovieGenres.ToList()
            };

            return View("", viewModel);
        }
    }
}