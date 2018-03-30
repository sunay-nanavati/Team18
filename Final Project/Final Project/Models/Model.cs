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

    public enum MPAA
    {
        G, PG, PG13, R
    }

    public enum TheaterNumber
    {
        Theater1, Theater2
    }

    public enum OrderStatus
    {
        Gift, NotGift //not sure what goes here
    }
    public class User
    {
        public Int32 UserID { get; set; }

        public String Email { get; set; } 

        public String Password { get; set; }

        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Display(Name = "Street Address")]
        public String StreetAddress { get; set; }

        public String City { get; set; }

        public String State { get; set; }

        [Display(Name = "ZIP Code")]
        public Int32 ZipCode { get; set; }

        public DateTime Birthday { get; set; }

        [Display(Name = "Popcorn Points")]
        public Int32 PopcornPoints { get; set; }

        [Display(Name = "Phone Number")]
        public Int32 PhoneNumber { get; set; }

        [Display(Name = "Employment Status")] //maybe?
        public Boolean IsEmployed { get; set; }

        public List<CreditCard> CreditCards { get; set; }
        public List<Order> Orders { get; set; }
    }

    public class CreditCard
    {
        public Int32 CreditCardID { get; set; }

        [Display(Name = "Credit Card Type ")]
        [Required(ErrorMessage = "Please enter valid CreditCardType")]
        public CreditCardType CreditCardType { get; set; }

        [Display(Name = "Credit Card Number")]
        [Required(ErrorMessage = "Please enter valid Credit Card Number")] //regex depends on cctype
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

    public class Ticket
    {
        public Int32 TicketID { get; set; }

        [Display(Name = "Seat Number")]
        public Int32 SeatNumber { get; set; }

        [Display(Name = "Ending Price")]
        public Decimal EndingPrice { get; set; }

        public Order Order { get; set; }
        public Showtime Showtime { get; set; }
    }

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
    
    public class Showtime
    {
        public Int32 ShowtimeID { get; set; }
        public DateTime StartTime { get; set; }
        public TheaterNumber TheaterNumber { get; set; }
        public DateTime EndTime { get; set; }
        public Boolean IsSpecialEvent { get; set; }

        public List<Ticket> Tickets { get; set; }
        public Movie Movie { get; set; }
    }
    
    public class Genre
    {
        public Int32 GenreID { get; set; }
        public String Name { get; set; }

        public List<Movie> Movies { get; set; }
    }

    public class Movie
    {
        public Int32 MovieID { get; set; }
        public String Title { get; set; }
        public String Tagline { get; set; }

        [Display(Name = "Release Year")]
        public DateTime ReleaseYear { get; set; }

        [Display(Name = "Customer Rating")]
        public Decimal CustomerRating { get; set; } //must be between 1.0 and 5.0, inclusive
        public MPAA MPAA { get; set; }
        public String Actors { get; set; }
        public String Overview { get; set; }
        
        public List<Showtime> Showtimes { get; set; }
        public List<Review> Reviews { get; set; }
        public Genre Genre { get; set; }
    }

    public class Review
    {
        public Int32 ReviewID { get; set; }

        [Display(Name = "Review Score")]
        public Decimal ReviewScore { get; set; } //1.0 - 5.0, inclusive

        [Display(Name = "Movie Review")]
        public String MovieReview { get; set; }
        public Boolean Upvote { get; set; } //maybe enum here
        public Boolean Approved { get; set; }

        public Movie Movie { get; set; }
        public User User { get; set; }
    }
}
