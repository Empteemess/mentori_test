using Domain.Entities;
using Domain.IRepositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class ClassesRepository : IClassesRepository
{
    private DbSet<Class> _classes;

    public ClassesRepository(AppDbContext context)
    {
        _classes = context.Set<Class>();
    }

    public async Task<Class> GetByIdAsync(Guid id)
    {
        var classes = await _classes.FindAsync(id);
        return classes;
    }

    public async Task<IEnumerable<Class>> GetAllAsync()
    {
        var classes = await _classes.ToListAsync();
        return classes;
    }

    public async Task AddAsync(Class entity)
    {
        await _classes.AddAsync(entity);
    }

    public async Task RemoveAsync(Guid id)
    {
        var classes = await _classes.FindAsync(id);
        _classes.Remove(classes);
    }
}