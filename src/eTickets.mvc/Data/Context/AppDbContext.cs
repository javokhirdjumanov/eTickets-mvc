using eTickets.mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.mvc.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor_Movie>().HasKey(am => new
        {
            am.ActorId,
            am.MovieId
        });

        modelBuilder.Entity<Actor_Movie>()
            .HasOne(am => am.Movie)
            .WithMany(m => m.Actor_Movies)
            .HasForeignKey(am => am.MovieId);

        modelBuilder.Entity<Actor_Movie>()
            .HasOne(am => am.Actor)
            .WithMany(a => a.Actor_Movies)
            .HasForeignKey(am => am.ActorId);

        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Actor> Actors { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Producer> Producers { get; set; }
    public DbSet<Actor_Movie> Actor_Movies { get; set; }
}
