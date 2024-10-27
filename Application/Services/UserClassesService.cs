using Application.Dtos.UserClassDtos;
using Application.IServices;
using Application.Mappers;
using Domain.IRepositories;

namespace Application.Services;

public class UserClassesService : IUserClassesService
{
    private readonly IUnitOfWork _unitOfWork;

    public UserClassesService(IUnitOfWork unitOfWork)
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