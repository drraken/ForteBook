using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ForteBook.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<GenreType> GenreTypes { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
   
    }
}