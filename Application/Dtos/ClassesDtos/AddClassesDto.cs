using Domain.Enums;

namespace Application.Dtos.ClassesDtos;

public class AddClassesDto
{
    public string OwnerId { get; set; }
    public string Hours { get; set; }
    public IEnumerable<DaysEnum> days { get; set; }
}