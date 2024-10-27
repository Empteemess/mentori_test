namespace Domain.Entities;

public class UserGroup
{
    public Guid Id { get; set; }
    
    public string UserId { get; set; }
    public ApplicationUser ApplicationUser { get; set; }

    public Guid classesId { get; set; }
    public Group Group { get; set; }
}