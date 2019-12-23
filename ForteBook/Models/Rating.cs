using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity;

namespace ForteBook.Models
{
    public class Rating
    {
        public int Id { get; set; }

        [Required]
        public int Value { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        [Display(Name = "User")]
        public string ApplicationUserId { get; set; } 

        public Book Book { get; set; }

        [Required]
        [Display(Name = "Book")]
        [OnlyOneRatingPerBook]
        public int BookId { get; set; }

       public Rating()
        {
            ApplicationUserId = System.Web.HttpContext.Current.User.Identity.Name;
        }
    }
}