using Application.Dtos.ClassesDtos;
using Application.IServices;
using Application.Mappers;
using Domain.IRepositories;

namespace Application.Services;

public class ClassesService : IClassesService
{
    private readonly IUnitOfWork _unitOfWork;

    public ClassesService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    public async Task<ClassesDto> GetByIdAsync(Guid id)
    {
        var classes = await _unitOfWork.ClassesRepository.GetByIdAsync(id);
        var mappedClass = classes.MapToClassesDto();
        return mappedClass;
    }

    public async Task<IEnumerable<ClassesDto>> GetAllAsync()
    {
        var classes = await _unitOfWork.ClassesRepository.GetAllAsync();
        var mappedClass = classes.Select(classes => classes.MapToClassesDto());
        return mappedClass;
    }

    public async Task AddAsync(AddClassesDto entity)
    {
        var mappedClass = entity.MapToClasses();
        await _unitOfWork.ClassesRepository.AddAsync(mappedClass);
        await _unitOfWork.SaveChangesAsync();
    }

    public async Task RemoveAsync(Guid id)
    {
        await _unitOfWork.ClassesRepository.RemoveAsync(id);
        await _unitOfWork.SaveChangesAsync();
    }
}