using System.Data;
using Microsoft.EntityFrameworkCore;
using Service2.Entities;

namespace Service2.Utils;

public class NDBcontext : DbContext
{
    public NDBcontext(DbContextOptions<NDBcontext> options) // jib l configuration l db (look program.cs)
        : base(options) { }

    public DbSet<Product> Products { get; set; } // this class y3ni is mapped to a database table named Persons 
    public DbSet<Commande> Commandes { get; set;  }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
        // configuration manuel des entites => relation onetomany , cle p etc ....
    {
        modelBuilder.Entity<Product>().HasKey(p => p.Id);
        modelBuilder.Entity<Commande>().HasKey(c => c.Id); 
    }
}