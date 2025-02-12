namespace RYHME.Models;

public class Album
{
    public int Id { get; set; }
    public string Title { get; set; }
    public int ArtistId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public virtual Artist Artist { get; set; }
    public virtual ICollection<Song> Songs { get; set; }
    public virtual ICollection<Release> Releases { get; set; }
}
