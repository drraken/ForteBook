﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ForteBook.Models;
using ForteBook.ViewModels;
using Microsoft.AspNet.Identity;

namespace ForteBook.Controllers
{
    public class UsersController : Controller
    {
        private ApplicationDbContext _context;

        public UsersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Save(User user)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        var viewModel = new UserFormViewModel
        //        {
        //            User = user
        //        };
        //        return View("UserForm",viewModel);
        //    }
        //    if (user.Id == 0)
        //        _context.Users.Add(user);
        //    else
        //    {
        //        var userInDb = _context.Users.Single(u => u.Id == user.Id);
        //        userInDb.FirstName = user.FirstName;
        //        userInDb.LastName = user.LastName;
        //        userInDb.IsSubscribedToNewsletter = user.IsSubscribedToNewsletter;
        //    }

        //    _context.SaveChanges();

        //    return RedirectToAction("Index","Users");
        //}
        public ViewResult Index()
        {
            var users = _context.Users.ToList();

            if (User.IsInRole("CanManageBooks"))
                return View(users);

            return View("ReadOnlyIndex",users);
        }
        public ActionResult Details(string id)
        {
            var user = _context.Users.SingleOrDefault(c => c.Id == id);

            if (user == null)
                return HttpNotFound();
            return View(user);
        }
        //public ActionResult Edit(int id)
        //{
        //    var user = _context.Users.SingleOrDefault(u => u.Id == id);
        //    if (user == null)
        //        return HttpNotFound();

        //    var viewModel = new UserFormViewModel
        //    {
        //        User = user
        //    };
        //    return View("UserForm", viewModel);
        //}
    }
}