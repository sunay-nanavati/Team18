using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public enum MPAA
    {
        G , PG , PG13 , R , NC17
    }

    public class Movie
    {
        [Required]
        [Display(Name = "Movie ID")] 
        public Int32 MovieID { get; set; }
        
        [Required]
        [Display(Name = "Movie Number")] 
        public Int32 MovieNumber { get; set; }
        
        [Required(ErrorMessage = "Please enter valid Title")]
        [Display(Name = "Title")] 
        public String Title { get; set; }
        
        [Display(Name = "Tagline")] 
        public String Tagline { get; set; }

        [Required(ErrorMessage = "Please enter valid Release Year")]
        [Display(Name = "Release Year")]
        public DateTime ReleaseYear { get; set; }
        
        [Required(ErrorMessage = "Please enter valid running time")]
        [Display(Name = "Running Time")] 
        public Int32 RunTime { get; set; }

        [Required(ErrorMessage = "Please enter valid Custoemr Rating")]
        [Display(Name = "Customer Rating")]
        public Decimal CustomerRating { get; set; } //must be between 1.0 and 5.0, inclusive
        
        [Required(ErrorMessage = "Please enter valid MPAA Rating")]
        [Display(Name = "MPAA Rating")] 
        public MPAA MPAA { get; set; }
        
        [Required(ErrorMessage = "Please enter at least one Actor")]
        [Display(Name = "Actors")] 
        public String Actors { get; set; }
        
        [Required(ErrorMessage = "Please enter Overview")]
        [Display(Name = "Overview")] 
        public String Overview { get; set; }
        
        public List<Showtime> Showtimes { get; set; }
        public List<Review> Reviews { get; set; }
        public Genre Genre { get; set; }
    }
}
