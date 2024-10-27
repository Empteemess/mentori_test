using Application.Dtos.ClassesDtos;
using Domain.Entities;

namespace Application.Mappers;

public static class GroupsMappers
{
    public static ClassesDto MapToClassesDto(this Group source)
    {
        var classDto = new ClassesDto()
        {
            Id = source.Id,
            OwnerId = source.OwnerId,
        };
        
        return classDto;
    }

    public static Group MapToClasses(this AddClassesDto source)
    {
        var clas = new Group()
        {
            OwnerId = source.OwnerId,
        };

        return clas;
    }
}