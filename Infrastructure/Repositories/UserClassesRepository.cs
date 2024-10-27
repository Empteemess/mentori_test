using Domain.Entities;
using Domain.IRepositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class UserClassesRepository : IUserClassesRepository
{
    private DbSet<UserGroup> _userClasses;
    public UserClassesRepository(AppDbContext appDbContext)
    {
        _userClasses = appDbContext.Set<UserGroup>();
    }
    public async Task<UserGroup> GetByIdAsync(Guid id)
    {
        var userClass =await _userClasses.FindAsync(id);
        return userClass;
    }

    public async Task<IEnumerable<UserGroup>> GetAllAsync()
    {
        var userClasses =await _userClasses.ToListAsync();
        return userClasses;
    }

    public async Task AddAsync(UserGroup entity)
    {
        await _userClasses.AddAsync(entity);
    }

    public async Task RemoveAsync(Guid id)
    {
        var userclasses = await _userClasses.FindAsync(id);
        _userClasses.Remove(userclasses);
    }
}