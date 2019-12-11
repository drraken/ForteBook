using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ForteBook.Models;


namespace ForteBook.Controllers.API
{
    public class BooksController : ApiController
    {
        private ApplicationDbContext _context;

        public BooksController()
        {
            _context = new ApplicationDbContext();
        }
       
        // DELETE /api/users/1
        [HttpDelete]
        public void DeleteBook(int id)
        {
            var bookInDb = _context.Books.SingleOrDefault(u => u.Id == id);

            if (bookInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Books.Remove(bookInDb);
            _context.SaveChanges();
        }
    }
}
