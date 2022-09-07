using Microsoft.EntityFrameworkCore;

namespace my_book_store_v1.Data.Models
{
    public class AppDBContext:DbContext 
    {
        public AppDBContext(DbContextOptions<AppDBContext> options ): base(options)
        {

        }
        public DbSet<Books> Books { get; set; }

    }
}
