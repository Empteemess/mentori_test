using Application.Dtos.ClassesDtos;
using Application.Dtos.UserClassDtos;
using Application.IServices;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Web.api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserGroupController : ControllerBase
{
    private readonly IUserClassesService _userClassesService;

    public UserGroupController(IUserClassesService userClassesService)
    {
        _userClassesService = userClassesService;
    }

 
    [HttpPost("userclasses")]
    public async Task<IActionResult> AddUSerClassesAsync([FromBody] AddUserClassDto addUserClassDto)
    {
        try
        {
            await _userClassesService.AddUserClassAsync(addUserClassDto);
            return Ok("User Class Added");
        }
        catch (Exception e)
        {
            return BadRequest($"Failed to add user class {e.Message}");
        }
    }
}