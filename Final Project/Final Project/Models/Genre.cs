using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Genre
    {
        public Int32 GenreID { get; set; }
        
        [Required(ErrorMessage = "Please enter at least one Genre")]
        public String Name { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
