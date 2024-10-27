using Application.Dtos.UserClassDtos;
using Domain.Entities;

namespace Application.Mappers;

public static class UserClassMappers
{
    public static UserClass MapToUserClasses(this AddUserClassDto addUserClassDto)
    {
        var userclasses = new UserClass()
        {
            UserId = addUserClassDto.UserId,
            classesId = addUserClassDto.classesId
        };
        
        return userclasses;;
    }
}