using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ForteBook.Models;

namespace ForteBook.ViewModels
{
    public class BookRatingViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<Rating> Ratings { get; set; }
        
    }
}