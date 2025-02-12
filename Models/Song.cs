namespace RYHME.Models;

public class Song
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int AlbumId { get; set; }
    public TimeSpan Duration { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public virtual Album Album { get; set; }
    public virtual ICollection<Release> Releases { get; set; }
}
