
using Microsoft.EntityFrameworkCore;

class OurContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<TaskItem> Tasks { get; set; }
    public DbSet<Filed> Fileds { get; set; }
    public DbSet<Priorty> priorties { get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(" Server=.;Database = TaskDb;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
