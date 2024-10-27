using Application.Dtos.ClassesDtos;

namespace Application.IServices;

public interface IClassesService
{
    Task<ClassesDto> GetByIdAsync(Guid id);
    Task<IEnumerable<ClassesDto>> GetAllAsync();
    Task AddAsync(AddClassesDto entity);
    Task RemoveAsync(Guid id);
}