using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Review
    {
        [Required]
        [Display(Name = "Review ID")]
        public Int32 ReviewID { get; set; }

        [Required]
        [Display(Name = "Review Score")]
        public Decimal ReviewScore { get; set; } //1.0 - 5.0, inclusive

        [Required]
        [Display(Name = "Movie Review")]
        public String MovieReview { get; set; }
        
        [Display(Name = "Upvote")]
        public Boolean Upvote { get; set; } //maybe enum here; this might need to be Int32
        
        [Display(Name = "Approved")]
        public Boolean Approved { get; set; } //default to false (?)

        public Movie Movie { get; set; }
        public User User { get; set; }
    }
}
