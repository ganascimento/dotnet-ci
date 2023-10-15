using Dotnet.CI.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Dotnet.CI.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class MathController : ControllerBase
{
    private readonly IMathService _mathService;

    public MathController(IMathService mathService)
    {
        _mathService = mathService;
    }

    [HttpGet("sum")]
    public IActionResult Sum(decimal value1, decimal value2)
    {
        try
        {
            var result = _mathService.Sum(value1, value2);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("sub")]
    public IActionResult Sub(decimal value1, decimal value2)
    {
        try
        {
            var result = _mathService.Sub(value1, value2);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("multi")]
    public IActionResult Mult(decimal value1, decimal value2)
    {
        try
        {
            var result = _mathService.Mult(value1, value2);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("div")]
    public IActionResult Div(decimal value1, decimal value2)
    {
        try
        {
            var result = _mathService.Div(value1, value2);
            return Ok(result);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}