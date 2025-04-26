using Microsoft.EntityFrameworkCore;
using WebApplication1.Model;

namespace WebApplication1.Utils;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options) // jib l configuration l db (look program.cs)
        : base(options) { }

    public DbSet<Person> Persons { get; set; } // this class y3ni is mapped to a database table named Persons 
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    // configuration manuel des entites => relation onetomany , cle p etc ....
    {
        modelBuilder.Entity<Person>().HasKey(p => p.Id);
    }

}