using Microsoft.EntityFrameworkCore;

using CodeFF.Models; // Adjust the namespace according to your project structure
namespace CodeFF.Data {

    public class BookContext : DbContext    
    {
 
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }
        public DbSet<Models.Book> Books { get; set; } // Assuming you have a Book model in the Models namespace
    }

}
