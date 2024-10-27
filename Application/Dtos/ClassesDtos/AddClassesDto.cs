using Domain.Entities;
using Domain.Enums;

namespace Application.Dtos.ClassesDtos;

public class AddClassesDto
{
    public string OwnerId { get; set; }
    public IEnumerable<Days> Days { get; set; }
}