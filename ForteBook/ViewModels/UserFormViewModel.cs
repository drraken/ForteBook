﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ForteBook.Models;

namespace ForteBook.ViewModels
{
    public class UserFormViewModel
    {
        public User User { get; set; }
        public string Title
        {
            get
            {
                if (User != null && User.Id != 0)
                    return "Edit User";
                return "New User";
            }
        }
    }
}