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
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{MM/dd/yyyy}")]
        public DateTime ReleaseDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{MM/dd/yyyy}")]
        public DateTime DateAdded { get; set; }
        [Required]
        public int NumberInStock { get; set; }
        [Required]
        public MovieGenre MovieGenre { get; set; }
        public byte MovieGenreId { get; set; }
    }
}