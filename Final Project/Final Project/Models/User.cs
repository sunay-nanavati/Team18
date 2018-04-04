using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    
    public class User
    {
        public Int32 UserID { get; set; }
                
        [Required(ErrorMessage = "Please enter valid Email")]
        public String Email { get; set; } 
        
        [Required(ErrorMessage = "Please enter a Password")]
        public String Password { get; set; }
        
        [Required(ErrorMessage = "Please enter a First Name")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a Last Name")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }
        
        [Required(ErrorMessage = "Please enter Street Address")]
        [Display(Name = "Street Address")]
        public String StreetAddress { get; set; }
        
        [Required(ErrorMessage = "Please enter a valid City")]
        public String City { get; set; }
        
        [Required(ErrorMessage = "Please enter valid State")]
        public String State { get; set; }

        [Required(ErrorMessage = "Please enter valid ZIP Code")]
        [Display(Name = "ZIP Code")]
        public Int32 ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter valid birthday")]
        public DateTime Birthday { get; set; }

        [Display(Name = "Popcorn Points")]
        public Int32 PopcornPoints { get; set; }
        
        [Required(ErrorMessage = "Please enter valid phone number")]
        [Display(Name = "Phone Number")]
        public Int32 PhoneNumber { get; set; }

        [Display(Name = "Employment Status")] //maybe?
        public Boolean IsEmployed { get; set; }

        public List<CreditCard> CreditCards { get; set; }
        public List<Order> Orders { get; set; }
    }
}
