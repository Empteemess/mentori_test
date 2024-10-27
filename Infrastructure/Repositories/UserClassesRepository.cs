using Domain.Entities;
using Domain.IRepositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class UserClassesRepository : IUserClassesRepository
{
    private DbSet<UserClass> _userClasses;
    public UserClassesRepository(AppDbContext appDbContext)
    {
        _userClasses = appDbContext.Set<UserClass>();
    }
    public async Task<UserClass> GetByIdAsync(Guid id)
    {
        var userClass =await _userClasses.FindAsync(id);
        return userClass;
    }

    public async Task<IEnumerable<UserClass>> GetAllAsync()
    {
        var userClasses =await _userClasses.ToListAsync();
        return userClasses;
    }

    public async Task AddAsync(UserClass entity)
    {
        await _userClasses.AddAsync(entity);
    }

    public async Task RemoveAsync(Guid id)
    {
        var userclasses = await _userClasses.FindAsync(id);
        _userClasses.Remove(userclasses);
    }
}