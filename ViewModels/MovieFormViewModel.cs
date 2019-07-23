using FullStackMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullStackMVC5.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<MovieGenre> MovieGenres { get; set; }
        public Movie Movie { get; set; }
    }
}