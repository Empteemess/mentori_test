using Application.Dtos.UserClassDtos;
using Application.Dtos.UserDtos;
using Application.IServices;
using Application.Mappers;
using Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Application.Services;

public class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;

    public UserService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<UserClassesResponseDto> GetUserClassesByIdAsync(string userId)
    {
        var user = await _unitOfWork.UserManager.Users
            .FirstOrDefaultAsync(x => x.Id == userId);
        
        var classes = await _unitOfWork.ClassesRepository.GetAllAsync();
        

        var res = new UserClassesResponseDto()
        {
            UserId = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName,
            Classes = classes.Where(x => x.OwnerId == userId)
        };

        return res;
    }

    public async Task<UserDto> GetByIdAsync(string id)
    {
        var user = await _unitOfWork.UserManager.FindByIdAsync(id);
        var mappedUser = user.MapToUserDto();
        return mappedUser;
    }

    public async Task<IEnumerable<UserDto>> GetAllAsync()
    {
        var user = await _unitOfWork.UserManager.Users.ToListAsync();
        var mappedUser = user.Select(x => x.MapToUserDto());
        return mappedUser;
    }

    public async Task AddAsync(AddUserDto entity)
    {
        var user = entity.MapToAddUserDto();
        var res = await _unitOfWork.UserManager.CreateAsync(user, entity.Password);
    }

    public async Task RemoveAsync(string id)
    {
        var user = await _unitOfWork.UserManager.FindByIdAsync(id);
        await _unitOfWork.UserManager.DeleteAsync(user);
    }
}