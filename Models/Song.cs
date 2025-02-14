using System.ComponentModel.DataAnnotations;

namespace RYHME.Models;

public class Song
{

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Title { get; set; }

    public int AlbumId { get; set; }
    public int Duration { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public virtual Album Album { get; set; }
    public virtual ICollection<Release> Releases { get; set; }
}
