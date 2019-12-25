using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using ForteBook.Models;
using ForteBook.ViewModels;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace ForteBook.Controllers
{
    public class RatingsController : Controller
    {
        private ApplicationDbContext _context;

        public RatingsController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        
        public ActionResult Ratings(int id)
        {
            var book = _context.Books.SingleOrDefault(b => b.Id == id);
            var viewModel = new RatingsViewModel
            {
                Rating = new Rating(),
                Book = book
            };

            return View("Ratings", viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public ActionResult SaveRating(int id, Rating rating)
        {
            if (!ModelState.IsValid)
            {
                var book = _context.Books.SingleOrDefault(b => b.Id == id);

                var viewModel = new RatingsViewModel
                {
                    Rating = new Rating(),
                    Book = book

                };
                return View("Ratings", viewModel);
            }



            _context.Ratings.Add(rating);
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }

            return RedirectToAction("Index", "Books");
        }
       
    }
}
