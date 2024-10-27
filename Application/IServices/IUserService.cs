using Application.Dtos.UserClassDtos;
using Application.Dtos.UserDtos;

namespace Application.IServices;

public interface IUserService
{
    Task<UserClassesResponseDto> GetUserClassesByIdAsync(string userId);
    Task<UserDto> GetByIdAsync(string id);
    Task<IEnumerable<UserDto>> GetAllAsync();
    Task AddAsync(AddUserDto entity);
    Task RemoveAsync(string id);
}