using Application.Dtos.ClassesDtos;
using Application.Dtos.UserDtos;
using Application.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Web.api.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    [HttpGet]
    public async Task<IActionResult> GetById(string id)
    {
        try
        {   
            var res = await _userService.GetUserClassesByIdAsync(id);
            return Ok(res);
        }
        catch (Exception e)
        {
            return BadRequest($"User not found with id: {id}");
        }
    }
    
    
    [HttpPost("register")]
    public async Task<IActionResult> RegisterAsync([FromBody] AddUserDto entity)
    {
        try
        {
            await _userService.AddAsync(entity);
            return Ok("register successful");


        }
        catch (Exception e)
        {
            return BadRequest($"register failed -> {e.Message}");
        }
    }
}