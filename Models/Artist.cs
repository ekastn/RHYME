using System.ComponentModel.DataAnnotations;

namespace RYHME.Models;

public class Artist
{

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [Required]
    [MaxLength(32)]
    public string Genre { get; set; }

    [Required]
    [MaxLength(32)]
    public string Contact { get; set; }

    public int ManagerId { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Album> Albums { get; set; }
    public virtual User Manager { get; set; }

}
