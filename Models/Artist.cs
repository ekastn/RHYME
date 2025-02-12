using System.ComponentModel.DataAnnotations;

namespace RYHME.Models;

public class Artist
{

    public int Id { get; set; }
    public string Name { get; set; }
    public string Genre { get; set; }
    public string Contact { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Album> Albums { get; set; }

}
