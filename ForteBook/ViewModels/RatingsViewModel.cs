﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ForteBook.Models;

namespace ForteBook.ViewModels
{
    public class RatingsViewModel
    {
        public Rating Rating { get; set; }    
        public Book Book { get; set; }
        
    }
}