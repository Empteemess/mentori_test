using Domain.Enums;

namespace Domain.Entities;

public class Class
{
    public Guid Id { get; set; }
    public string OwnerId { get; set; }
    public string Hours { get; set; }
    public IEnumerable<DaysEnum> days { get; set; }

    public IEnumerable<UserClass> UserClasses { get; set; }
}