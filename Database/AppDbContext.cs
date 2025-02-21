using Microsoft.EntityFrameworkCore;
using RYHME.Models;
using RYHME.Utils;

namespace RYHME.Database;

public class AppDbContext : DbContext
{
    private readonly SessionManager _sessionManager;

    public AppDbContext(SessionManager sessionManager)
    {
        _sessionManager = sessionManager;
    }

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

        modelBuilder.Entity<Artist>()
            .HasOne(a => a.Manager)
            .WithMany(u => u.Artists)
            .HasForeignKey(a => a.ManagerId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Release>()
           .HasOne(r => r.Album)
           .WithMany(a => a.Releases)
           .HasForeignKey(r => r.AlbumId)
           .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Release>()
            .HasOne(r => r.Song)
            .WithMany(a => a.Releases)
            .HasForeignKey(r => r.SongId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Release>()
            .HasOne(r => r.CreatedBy)
            .WithMany(a => a.Releases)
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

    public override int SaveChanges()
    {
        var loggedInUser = _sessionManager.GetLoggedInUser();
        if (loggedInUser != null)
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.Entity is Artist artist)
                {
                    artist.ManagerId = loggedInUser.Id;
                }
                else if (entry.Entity is Release release)
                {
                    release.CreatedByUserId = loggedInUser.Id;
                }
            }
        }
        return base.SaveChanges();
    }
}
