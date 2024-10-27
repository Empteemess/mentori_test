using System.ComponentModel.DataAnnotations;
using Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities;

public class ApplicationUser : IdentityUser
{
    [MaxLength(25)]
    public string? FirstName { get; set; }
    [MaxLength(25)]
    public string? LastName { get; set; }
    public DateTime BirthYear { get; set; }
    public RoleEnum Role { get; set; }
    public DegreeEnum Degree { get; set; }
    public GenderEnum Gender { get; set; }
    
    public IEnumerable<UserClass> UserClasses { get; set; }
}