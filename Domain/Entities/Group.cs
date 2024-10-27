using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Domain.Entities;

public class Group
{
    public Guid Id { get; set; }
    [MaxLength(60)]
    public required string OwnerId { get; set; }
    
    public IEnumerable<Days>? Days { get; set; }

    public IEnumerable<UserGroup>? UserClasses { get; set; }
}