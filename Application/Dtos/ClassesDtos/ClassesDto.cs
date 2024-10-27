using Domain.Enums;

namespace Application.Dtos.ClassesDtos;

public class ClassesDto
{
    public Guid Id { get; set; }
    public string OwnerId { get; set; }
    public string Hours { get; set; }
    public IEnumerable<DaysEnum> days { get; set; }
}