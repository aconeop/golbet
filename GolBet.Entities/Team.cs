using System.ComponentModel.DataAnnotations;
using GolBet.Entities.Common;

namespace GolBet.Entities;

public class Team : AuditableEntity
{
    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;

    public string City { get; set; } = string.Empty;

    [MaxLength(500)]
    public string? CrestUrl { get; set; }
}
