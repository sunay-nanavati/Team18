using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public enum MPAA
    {
        G, PG, PG13, R
    }

    public class Movie
    {
        public Int32 MovieID { get; set; }
        public String Title { get; set; }
        public String Tagline { get; set; }

        [Display(Name = "Release Year")]
        public DateTime ReleaseYear { get; set; }

        [Display(Name = "Customer Rating")]
        public Decimal CustomerRating { get; set; } //must be between 1.0 and 5.0, inclusive
        public MPAA MPAA { get; set; }
        public String Actors { get; set; }
        public String Overview { get; set; }
        
        public List<Showtime> Showtimes { get; set; }
        public List<Review> Reviews { get; set; }
        public Genre Genre { get; set; }
    }
}
