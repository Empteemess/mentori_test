using System.ComponentModel.DataAnnotations;
using Application.Dtos.ClassesDtos;
using Application.Dtos.UserDtos;
using Domain.Entities;
using Domain.Enums;

namespace Application.Dtos.UserClassDtos;

public class UserClassesResponseDto
{
    public string UserId { get; set; }
    [MaxLength(25)]
    public string? FirstName { get; set; }
    [MaxLength(25)]
    public string? LastName { get; set; }
    public IEnumerable<Group> Classes { get; set; }
}