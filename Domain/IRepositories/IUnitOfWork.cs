using Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace Domain.IRepositories;

public interface IUnitOfWork
{
    UserManager<ApplicationUser> UserManager { get; }
    public IClassesRepository ClassesRepository { get; }
    public IUserClassesRepository UserClassRepository { get; }
    public Task SaveChangesAsync();
}