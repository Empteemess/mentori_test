using Domain.Entities;
using Domain.IRepositories;
using Infrastructure.Data;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context,
        UserManager<ApplicationUser> userManager,
        IClassesRepository classesRepository,
        IUserClassesRepository userClassRepository
        )
    {
        _context = context;
        UserManager = userManager;
        ClassesRepository = classesRepository;
        UserClassRepository = userClassRepository;
    }
    
    public UserManager<ApplicationUser> UserManager { get; }
    public IClassesRepository ClassesRepository { get; set; }
    public IUserClassesRepository UserClassRepository { get; }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}