using Microsoft.EntityFrameworkCore;
using RYHME.Models;

namespace RYHME.Database;

public class AppDbContext : DbContext
{
    public DbSet<Artist> Artists { get; set; }
    public DbSet<Album> Albums { get; set; }
    public DbSet<Song> Songs { get; set; }
    public DbSet<Release> Releases { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "server=localhost;database=rhyme;user=root;password=";
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Album>()
            .HasOne(a => a.Artist)
            .WithMany(a => a.Albums)
            .HasForeignKey(a => a.ArtistId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Song>()
            .HasOne(s => s.Album)
            .WithMany(a => a.Songs)
            .HasForeignKey(s => s.AlbumId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Release>()
           .HasOne(r => r.Album)
           .WithMany()
           .HasForeignKey(r => r.AlbumId)
           .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Release>()
            .HasOne(r => r.Song)
            .WithMany()
            .HasForeignKey(r => r.SongId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Release>()
            .HasOne(r => r.CreatedBy)
            .WithMany()
            .HasForeignKey(r => r.CreatedByUserId)
            .OnDelete(DeleteBehavior.Restrict);

        foreach (var entityType in modelBuilder.Model.GetEntityTypes())
        {
            if (entityType.ClrType.GetProperty("CreatedAt") != null)
            {
                modelBuilder.Entity(entityType.ClrType)
                    .Property("CreatedAt")
                    .HasDefaultValueSql("CURRENT_TIMESTAMP"); // MySQL syntax
            }
        }
    }
}
