using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data
{
    public class ApplicationDBContext : DbContext
    {
        // Options that are recieved in the constructor will be passed to the base class (DBContext)
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        // Creating the catergory table inside the database
        public DbSet<Category> Categories { get; set; }
    }
}
