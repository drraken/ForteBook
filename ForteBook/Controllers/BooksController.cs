using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ForteBook.Models;
using ForteBook.ViewModels;

namespace ForteBook.Controllers
{
    public class BooksController : Controller
    {
        
        private ApplicationDbContext _context;

        public BooksController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var books = _context.Books.Include(b => b.GenreType).ToList();

            return View(books);
        }
        public ActionResult Details(int id)
        {
            var book = _context.Books.Include(b => b.GenreType).SingleOrDefault(b => b.Id == id);

            if (book == null)
                return HttpNotFound();

            return View(book);
        }
        public ActionResult BookForm()
        {
            var genreTypes = _context.GenreTypes.ToList();
            var viewModel = new BookFormViewModel
            {
                Book = new Book(),
                GenreTypes = genreTypes
            };

            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Book book)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new BookFormViewModel
                {
                    Book = book,
                    GenreTypes = _context.GenreTypes.ToList()
                };
                return View("BookForm", viewModel);
            }
            if (book.Id == 0)
                _context.Books.Add(book);
            else
            {
                var bookInDb = _context.Books.Single(b => b.Id == book.Id);

                bookInDb.Name = book.Name;
                bookInDb.GenreTypeId = book.GenreTypeId;
                bookInDb.Description = book.Description;

            }
            try
            {
                _context.SaveChanges();
            }
            catch(DbEntityValidationException e)
            {
                Console.WriteLine(e);
            }
            

            return RedirectToAction("Index", "Books");
        }
        public ActionResult Edit(int id)
        {
            var book = _context.Books.SingleOrDefault(b => b.Id == id);
            if (book == null)
                return HttpNotFound();

            var viewModel = new BookFormViewModel
            {
                Book = book,
                GenreTypes = _context.GenreTypes.ToList()
            };
            return View("BookForm", viewModel);
        }
    }

    //[Route("books/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
    //public ActionResult ByReleaseDate(int year, int month)
    //{
    //    return Content(year + "/" + month);
    //}

}