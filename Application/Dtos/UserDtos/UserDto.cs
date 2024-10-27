using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Application.Dtos.UserDtos;

public class UserDto
{
    public string UserId { get; set; }
    [MaxLength(25)]
    public string? FirstName { get; set; }
    [MaxLength(25)]
    public string? LastName { get; set; }
    public DateTime BirthYear { get; set; }
    public RoleEnum Role { get; set; }
    public DegreeEnum Degree { get; set; }
    public GenderEnum Gender { get; set; }   
}