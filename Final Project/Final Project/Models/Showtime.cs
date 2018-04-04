using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public enum TheaterNumber
    {
        Theater1, Theater2
    }
    
    public class Showtime
    {
        [Required]
        [Display(Name = "Showtime ID")]
        public Int32 ShowtimeID { get; set; }
        
        [Required]
        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }
        
        [Required]
        [Display(Name = "Theater Number")]
        public TheaterNumber TheaterNumber { get; set; }
        
        [Required]
        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }
        
        [Required]
        [Display(Name = "Special Event Status")]
        public Boolean IsSpecialEvent { get; set; }

        public List<Ticket> Tickets { get; set; }
        public Movie Movie { get; set; }
    }
}
