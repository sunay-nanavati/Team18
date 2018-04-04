using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public enum OrderStatus
    {
        Gift, NotGift //not sure what goes here
    }

    public class Order
    {
        public Int32 OrderID { get; set; }

        [Display(Name = "Total Price")]
        public Decimal TotalPrice { get; set; }

        [Display(Name = "Popcorn Points Earned")]
        public Int32 PopcornpointsEarned { get; set; }

        [Display(Name = "Status")]
        public OrderStatus Status { get; set; }

        [Display(Name = "Cancelled")]
        public Boolean IsCancelled { get; set; }

        public User User { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
