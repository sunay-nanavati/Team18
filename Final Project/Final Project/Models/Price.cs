using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Price
    {
        [Required]
        [Display(Name = "Price ID")]
        public Int32 PriceID { get; set; }
        
        [Required]
        [Display(Name = "Matinee")]
        public Boolean IsMatinee { get; set; }
        
        [Required]
        [Display(Name = "Teusday")]
        public Boolean IsTuesday { get; set; }
        
        [Required]
        [Display(Name = "Senior")]
        public Boolean IsSenior { get; set; }
        
        [Required]
        [Display(Name = "Late Weekday")]
        public Boolean IsLateWeekday { get; set; }
        
        [Required]
        [Display(Name = "Weekend")]
        public Boolean IsWeekend { get; set; }
        
        [Required]
        [Display(Name = "Two Days in Advance")]
        public Boolean IsTwoDaysAdvance { get; set; }
    }
}
