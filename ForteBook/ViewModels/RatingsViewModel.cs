using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ForteBook.Models;

namespace ForteBook.ViewModels
{
    public class RatingsViewModel
    {
        public Rating Rating { get; set; }
        public IEnumerable<Book> Book { get; set; }
        //public IEnumerable<ApplicationUser> ApplicationUser { get; set; }
    }
}