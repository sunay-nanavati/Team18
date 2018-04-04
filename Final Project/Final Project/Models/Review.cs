using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Review
    {
        [Display(Name = "Review ID")]
        public Int32 ReviewID { get; set; }

        [Display(Name = "Review Score")]
        public Decimal ReviewScore { get; set; } //1.0 - 5.0, inclusive

        [Display(Name = "Movie Review")]
        public String MovieReview { get; set; }
        
        [Display(Name = "Upvote")]
        public Boolean Upvote { get; set; } //maybe enum here
        
        [Display(Name = "Approved")]
        public Boolean Approved { get; set; }

        public Movie Movie { get; set; }
        public User User { get; set; }
    }
}
