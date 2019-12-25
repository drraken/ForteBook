using System;
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
    }
}