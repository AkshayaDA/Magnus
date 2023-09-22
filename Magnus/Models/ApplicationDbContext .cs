using Magnus.Models;
using System.Data.Entity;

public class ApplicationDbContext : DbContext

{

    public ApplicationDbContext() : base("ApplicationDbContext")
    {
   }
    public DbSet<LoginViewModel> Users { get; set; }

    public System.Data.Entity.DbSet<Student> students { get; set; }
   // public DbSet<Student> students { get; set; }



}


