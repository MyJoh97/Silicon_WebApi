using System.ComponentModel.DataAnnotations;

namespace Infastructure.Entities;

public class SubscribersEntity
{
    [Key]
    public string Email { get; set; } = null!;
}
