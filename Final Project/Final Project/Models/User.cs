using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class User
    {
        [Required(ErrorMessage = "Please enter Username")] //??
        [Display(Name = "Username")]
        public String Username { get; set; } 
        
        [Required(ErrorMessage = "Please enter Password")] //??
        [Display(Name = "Passowrd")]
        public String Password { get; set; } 
        
        [Required]
        [Display(Name = "User ID")]
        public Int32 UserID { get; set; }
                
        [Required(ErrorMessage = "Please enter Email Address")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Please enter valid Email Address")]
        [Display(Name = "Email Address")]
        public String Email { get; set; } 
        
        [Required(ErrorMessage = "Please enter a Password")]
        [Display(Name = "Password")]
        public String Password { get; set; }
        
        [Required(ErrorMessage = "Please enter a First Name")]
        [Display(Name = "First Name")]
        public String FirstName { get; set; }
        
        [Display(Name = "Middle Initial")]
        [StringLength(1)]
        public String MiddleInitial { get; set; }

        [Required(ErrorMessage = "Please enter a Last Name")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }
        
        [Display(Name = "Street Address")]
        public String StreetAddress { get; set; }
        
        [Display(Name = "City")]
        public String City { get; set; }
        
        [Display(Name = "State")] //might need enum here
        public String State { get; set; }

        [Display(Name = "ZIP Code")]
        [StringLength(5)]
        public Int32 ZipCode { get; set; }

        [Required(ErrorMessage = "Please enter valid birthday")]
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }
        
        [Required]
        [Display(Name = "Popcorn Points")]
        public Int32 PopcornPoints { get; set; }
        
        [Required(ErrorMessage = "Please enter valid phone number")]
        [StringLength(10)]
        [Display(Name = "Phone Number")]
        public Int32 PhoneNumber { get; set; }
        
        [Required]
        [Display(Name = "Employment Status")] //maybe?
        public Boolean IsEmployed { get; set; }

        public List<CreditCard> CreditCards { get; set; }
        public List<Order> Orders { get; set; }
    }
}
