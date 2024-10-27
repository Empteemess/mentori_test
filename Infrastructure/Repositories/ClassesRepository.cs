using Domain.Entities;
using Domain.IRepositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class ClassesRepository : IClassesRepository
{
    private DbSet<Group> _classes;

    public ClassesRepository(AppDbContext context)
    {
        _classes = context.Set<Group>();
    }

    public async Task<Group> GetByIdAsync(Guid id)
    {
        var classes = await _classes.FindAsync(id);
        return classes;
    }

    public async Task<IEnumerable<Group>> GetAllAsync()
    {
        var classes = await _classes.ToListAsync();
        return classes;
    }

    public async Task AddAsync(Group entity)
    {
        await _classes.AddAsync(entity);
    }

    public async Task RemoveAsync(Guid id)
    {
        var classes = await _classes.FindAsync(id);
        _classes.Remove(classes);
    }
}