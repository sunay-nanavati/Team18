using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Review
    {
        public Int32 ReviewID { get; set; }

        [Display(Name = "Review Score")]
        public Decimal ReviewScore { get; set; } //1.0 - 5.0, inclusive

        [Display(Name = "Movie Review")]
        public String MovieReview { get; set; }
        public Boolean Upvote { get; set; } //maybe enum here
        public Boolean Approved { get; set; }

        public Movie Movie { get; set; }
        public User User { get; set; }
    }
}
