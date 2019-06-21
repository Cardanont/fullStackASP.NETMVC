using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FullStackMVC5.Models;
using FullStackMVC5.ViewModels;

namespace FullStackMVC5.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Index
        public ActionResult Index()
        {

            var movies = new List<Movie>
            {
                new Movie {Name = "Srek!"},
                new Movie {Name = "Wall-e"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }


        //GET: Movies/Random
        public ActionResult Random()
        {
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer1"},
                new Customer {Name = "Customer2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }
    }
}