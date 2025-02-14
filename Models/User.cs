using System.ComponentModel.DataAnnotations;

namespace RYHME.Models;

public class User
{

    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(32)]
    public string Username { get; set; }

    [Required]
    [MaxLength(64)]
    public string PasswordHash { get; set; }

    [Required]
    public UserRole Role { get; set; } = UserRole.Manager;

    [Required]
    [MaxLength(32)]
    public string Contact { get; set; }

    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<Release> Releases { get; set; }
    public virtual ICollection<Artist> Artists { get; set; }

}
