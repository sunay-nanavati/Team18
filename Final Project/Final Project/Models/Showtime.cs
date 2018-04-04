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
        public Int32 ShowtimeID { get; set; }
        public DateTime StartTime { get; set; }
        public TheaterNumber TheaterNumber { get; set; }
        public DateTime EndTime { get; set; }
        public Boolean IsSpecialEvent { get; set; }

        public List<Ticket> Tickets { get; set; }
        public Movie Movie { get; set; }
    }
}
