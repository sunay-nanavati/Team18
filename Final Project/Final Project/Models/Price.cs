using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class Price
    {
        public Int32 PriceID { get; set; }
        public Boolean IsMatinee { get; set; }
        public Boolean IsTuesday { get; set; }
        public Boolean IsSenior { get; set; }
        public Boolean IsLateWeekday { get; set; }
        public Boolean IsWeekend { get; set; }
        public Boolean IsTwoDaysAdvance { get; set; }
    }
}
