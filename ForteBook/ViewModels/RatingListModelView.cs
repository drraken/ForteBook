using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ForteBook.Models;

namespace ForteBook.ViewModels
{
    public class RatingListModelView
    {
        public IEnumerable<Book> Book { get; set; }
        public IEnumerable<Rating> Ratings { get; set; }
    }
}