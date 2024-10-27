using System.ComponentModel.DataAnnotations;

namespace Application.Dtos.UserDtos;

public class AddUserDto
{
    [MaxLength(25)]
    public string? FirstName { get; set; }
    [MaxLength(25)]
    public string? LastName { get; set; }

    public string Email { get; set; }
    public string Password { get; set; }
}