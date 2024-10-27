namespace Domain.Entities;

public class UserClass
{
    public Guid Id { get; set; }
    
    public string UserId { get; set; }
    public ApplicationUser ApplicationUser { get; set; }

    public Guid classesId { get; set; }
    public Class Class { get; set; }
}