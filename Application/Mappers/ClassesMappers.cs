using Application.Dtos.ClassesDtos;
using Domain.Entities;

namespace Application.Mappers;

public static class ClassesMappers
{
    public static ClassesDto MapToClassesDto(this Class source)
    {
        var classDto = new ClassesDto()
        {
            Id = source.Id,
            days = source.days,
            Hours = source.Hours,
            OwnerId = source.OwnerId,
        };
        
        return classDto;
    }

    public static Class MapToClasses(this AddClassesDto source)
    {
        var clas = new Class()
        {
            days = source.days,
            Hours = source.Hours,
            OwnerId = source.OwnerId,
        };

        return clas;
    }
}