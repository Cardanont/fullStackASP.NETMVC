﻿using FullStackMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullStackMVC5.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Moview { get; set; }
        public List<Customer> Customers { get; set; }
    }
}