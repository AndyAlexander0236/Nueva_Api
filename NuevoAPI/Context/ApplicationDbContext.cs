using Microsoft.EntityFrameworkCore;
public class ApplicationDBContext : DbContext
{
    public DbSet<Autor> Autores { get; set; }
    public DbSet<Libro> Libros { get; set; }

    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
