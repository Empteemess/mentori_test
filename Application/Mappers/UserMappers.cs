using Application.Dtos.UserDtos;
using Domain.Entities;

namespace Application.Mappers;

public static class UserMappers
{
    public static UserDto MapToUserDto(this ApplicationUser applicationUser)
    {
        var res  = new UserDto()
        {
            UserId = applicationUser.Id,
            FirstName = applicationUser.FirstName,
            LastName = applicationUser.LastName,
            BirthYear = applicationUser.BirthYear,
            Degree = applicationUser.Degree,
            Gender = applicationUser.Gender,
        };
        
        return res;
    }

    public static ApplicationUser MapToAddUserDto(this AddUserDto addUserDto)
    {
        var applicationUser = new ApplicationUser()
        {
            FirstName = addUserDto.FirstName,
            LastName = addUserDto.LastName,
            Email = addUserDto.Email,
            UserName = addUserDto.FirstName + addUserDto.LastName
        };
        return applicationUser;
    }
}