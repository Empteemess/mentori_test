using Application.Dtos.ClassesDtos;
using Application.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Web.api.Controllers;

[ApiController]
[Route("[controller]")]
public class ClassesController : ControllerBase
{
    private readonly IClassesService _classesService;

    public ClassesController(IClassesService classesService)
    {
        _classesService = classesService;
    }

    [HttpPost("group")]
    public async Task<IActionResult> AddGroup([FromBody] AddClassesDto addClassesDto)
    {
        try
        {
            await _classesService.AddAsync(addClassesDto);
            return Ok("Success");
        }
        catch (Exception e)
        {
            return BadRequest($"Failed to create group: {e.Message}");
        }
    }
}