using System;
using System.ComponentModel.DataAnnotations;

namespace Lab23.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required]
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Movie Title")]
        public string Title { get; set; }

        public double Runtime { get; set; }
    }
}
