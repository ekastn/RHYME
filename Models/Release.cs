using System.ComponentModel.DataAnnotations;

namespace RYHME.Models;

public class Release
{

    [Key]
    public int Id { get; set; }

    [Required]
    public ReleaseType Type { get; set; }  // Single or Album

    public int? AlbumId { get; set; }      // Null for singles
    public int? SongId { get; set; }       // Null for albums
    public ReleaseStatus Status { get; set; } = ReleaseStatus.Draft; 
    public DateTime ScheduledDate { get; set; }
    public DateTime? ReleaseDate { get; set; }
    public string Notes { get; set; }
    public int CreatedByUserId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public virtual User CreatedBy { get; set; }
    public virtual Album Album { get; set; }
    public virtual Song Song { get; set; }
}
