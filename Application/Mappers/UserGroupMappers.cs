using Application.Dtos.UserClassDtos;
using Domain.Entities;

namespace Application.Mappers;

public static class UserGroupMappers
{
    public static UserGroup MapToUserClasses(this AddUserClassDto addUserClassDto)
    {
        var userclasses = new UserGroup()
        {
            UserId = addUserClassDto.UserId,
            classesId = addUserClassDto.classesId
        };
        
        return userclasses;;
    }
}