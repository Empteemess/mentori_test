using Domain.Enums;

namespace Domain.Entities;

public class Days
{
    public DaysEnum WeekDay { get; set; }
    public string From { get; set; }
    public string To { get; set; }
}