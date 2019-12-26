using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ForteBook.Models;
using Microsoft.AspNet.Identity;

namespace ForteBook.Controllers.API
{
    public class UsersController : ApiController
    {
        private ApplicationDbContext _context;

        public UsersController()
        {
            _context = new ApplicationDbContext();
        }
        //GET /api/users
        public IEnumerable<ApplicationUser> GetUsers()
        {
            return _context.Users.ToList();
        }
        // GET /api/users/1
        public ApplicationUser GetUser(string id)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);

            if (user == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return user;
        }
        // DELETE /api/users/1
        [HttpDelete]
        public void DeleteUser(string id)
        {
            var userInDb = _context.Users.SingleOrDefault(u => u.Id == id);

            if (userInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Users.Remove(userInDb);
            _context.SaveChanges();
        }
    }
}
