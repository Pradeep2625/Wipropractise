using LMSApp.Models;
// Microsoft.EntityFrameworkCore is the core library for Entity Framework Core.
// It provides the DbContext base class and other essential tools.
using Microsoft.EntityFrameworkCore;

namespace LMSApp.Data
{
    // The LMSContext class is our custom DbContext.
    // It inherits from the base DbContext class, which gives it all the functionality
    // needed to interact with a database.
    public class LMSContext : DbContext
    {
        // This is the constructor for the LMSContext.
        // It takes DbContextOptions, which contain the database connection string
        // and other settings, and passes them to the base DbContext class.
        public LMSContext(DbContextOptions<LMSContext> options) : base(options) { }

        // These are the DbSet properties. Each DbSet represents a collection of
        // entities in the database, which typically corresponds to a database table.
        // This DbSet will be used to query and save instances of the Course model.
        // It will typically map to a 'Courses' table in the database.
        public DbSet<Course> Courses { get; set; }

        // This DbSet will be used to query and save instances of the Student model.
        // It will typically map to a 'Students' table in the database.
        public DbSet<Student> Students { get; set; } 
    }
}
