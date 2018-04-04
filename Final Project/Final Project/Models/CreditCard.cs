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
        [Required]
        [Display(Name = "Credit Card ID")] 
        public Int32 CreditCardID { get; set; }

        [Required(ErrorMessage = "Please enter valid CreditCardType")]
        [Display(Name = "Credit Card Type ")]
        public CreditCardType CreditCardType { get; set; }
        
        [Required(ErrorMessage = "Please enter valid Credit Card Number")] //regex depends on cctype
        [Display(Name = "Credit Card Number")]
        [DataType(DataType.CreditCard)]
        public Int32 CreditCardNumber { get; set; }
        
        [Required(ErrorMessage = "Please enter valid Expiration Date")]
        [Display(Name = "Expiration Date")]   
        public DateTime ExpirationDate { get; set; }

        [Required(ErrorMessage = "Please enter valid CVV")] //regex depends on cctype
        [Display(Name = "CVV")]  
        public Int32 CVV { get; set; }
        
        [Required(ErrorMessage = "Please enter Name")]
        [Display(Name = "Name")] 
        public String Name { get; set; }
        
        [Required(ErrorMessage = "Please enter valid Billing Address")]
        [Display(Name = "Billing Address")]    
        public String BillingAddress { get; set; }

        public User User { get; set; }
    }
}
