using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public enum CreditCardType
    {
        Visa, AmericanExpress, Discover, MasterCard
    }
    
    public class CreditCard
    {
        public Int32 CreditCardID { get; set; }

        [Display(Name = "Credit Card Type ")]
        [Required(ErrorMessage = "Please enter valid CreditCardType")]
        public CreditCardType CreditCardType { get; set; }

        [Display(Name = "Credit Card Number")]
        [Required(ErrorMessage = "Please enter valid Credit Card Number")] //regex depends on cctype
        [DataType(DataType.CreditCard)]
        public Int32 CreditCardNumber { get; set; }

        [Display(Name = "Expiration Date")]
        [Required(ErrorMessage = "Please enter valid Expiration Date")]
        public DateTime ExpirationDate { get; set; }

        [Display(Name = "CVV")]
        [Required(ErrorMessage = "Please enter valid CVV")] //regex depends on cctype
        public Int32 CVV { get; set; }

        public String Name { get; set; }

        [Display(Name = "Billing Address")]
        [Required(ErrorMessage = "Please enter valid Billing Address")]
        public String BillingAddress { get; set; }

        public User User { get; set; }
    }
}
