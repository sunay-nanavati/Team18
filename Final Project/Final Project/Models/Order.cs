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
        [Required]
        [Display(Name = "Order ID")] 
        public Int32 OrderID { get; set; }
        
        [Required(ErrorMessage = "Please enter Total Price")]
        [Display(Name = "Total Price")]
        public Decimal TotalPrice { get; set; }
        
        [Required(ErrorMessage = "Please enter Popcorn Points Earned")]
        [Display(Name = "Popcorn Points Earned")]
        public Int32 PopcornpointsEarned { get; set; }

        [Required(ErrorMessage = "Please enter Status")]
        [Display(Name = "Status")]
        public OrderStatus Status { get; set; }

        [Required(ErrorMessage = "Please enter Cancellation Status")]
        [Display(Name = "Cancellation Status")]
        public Boolean IsCancelled { get; set; }

        public User User { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
