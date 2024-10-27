using Application.Dtos.UserClassDtos;
using Application.IServices;
using Application.Mappers;
using Domain.IRepositories;

namespace Application.Services;

public class UserGroupService : IUserClassesService
{
    private readonly IUnitOfWork _unitOfWork;

    public UserGroupService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task AddUserClassAsync(AddUserClassDto addUserClassDto)
    {
        var mappedUserClass = addUserClassDto.MapToUserClasses();
        await _unitOfWork.UserClassRepository.AddAsync(mappedUserClass);
        await _unitOfWork.SaveChangesAsync();
    }
}