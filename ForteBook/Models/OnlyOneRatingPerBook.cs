using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using System.Web;

namespace ForteBook.Models
{
    public class OnlyOneRatingPerBook : ValidationAttribute
    {
        //public Rating ratingDb { get; set; }
        private ApplicationDbContext _context;

        public OnlyOneRatingPerBook()
        {
            _context = new ApplicationDbContext();
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
           var rating = (Rating)validationContext.ObjectInstance;


            var ratingDb = _context.Ratings.ToList();


            foreach (var element in ratingDb)
            {
                if (rating.BookId == element.BookId && rating.ApplicationUserId == element.ApplicationUserId)
                {
                    return new ValidationResult("You already rated this book.");
                }
               
            }
            return ValidationResult.Success;
            
           
           
        }
    }
}