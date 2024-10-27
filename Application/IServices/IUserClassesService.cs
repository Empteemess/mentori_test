using Application.Dtos.UserClassDtos;

namespace Application.IServices;

public interface IUserClassesService
{
    Task AddUserClassAsync(AddUserClassDto addUserClassDto);
}