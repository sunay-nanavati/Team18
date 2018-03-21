using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Price
    {
        [Display(Name = "Price ID")]
        public Int32 PriceID { get; set; }

        public decimal Matinee { get; set; }
        public decimal Tuesday { get; set; }
        public decimal Senior { get; set; }
        public decimal LateWeekday { get; set; }
        public decimal Weekends { get; set; }
        public decimal TwoDayAdvance { get; set; }
    }
}