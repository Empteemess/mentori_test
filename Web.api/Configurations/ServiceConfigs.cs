using Application.IServices;
using Application.Services;
using Domain.Entities;
using Domain.IRepositories;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Web.api.Configurations;

public static class ServiceConfigs
{
    public static IServiceCollection AddServiceConfigs(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(opt => opt
            .UseSqlServer(configuration
                .GetConnectionString("ConString")));

        services.AddIdentity<ApplicationUser, IdentityRole>()
            .AddEntityFrameworkStores<AppDbContext>()
            .AddDefaultTokenProviders();

        services.AddScoped<IUnitOfWork, UnitOfWork>();

        services.AddScoped<IClassesRepository, ClassesRepository>();
        services.AddScoped<IUserClassesRepository, UserClassesRepository>();
        
        services.AddScoped<IClassesService, ClassesService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IUserClassesService, UserClassesService>();
        
        return services;
    }
}