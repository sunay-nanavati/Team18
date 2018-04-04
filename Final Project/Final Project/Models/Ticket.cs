using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Ticket
    {
        [Required]
        [Display(Name = "Ticket ID")]
        public Int32 TicketID { get; set; }

        [Required]
        [Display(Name = "Seat Number")]
        public Int32 SeatNumber { get; set; }

        [Required]
        [Display(Name = "Ending Price")]
        public Decimal EndingPrice { get; set; }

        public Order Order { get; set; }
        public Showtime Showtime { get; set; }
    }
}
