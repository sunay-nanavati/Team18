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
        public String Name { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
