using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FullStackMVC5.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string  Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{MM/dd/yyyy}")]
        public DateTime DateAdded { get; set; }
        [Required]
        [Display(Name = "Number in Stock")]
        public int NumberInStock { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public MovieGenre MovieGenre { get; set; }
        public byte MovieGenreId { get; set; }
    }
}