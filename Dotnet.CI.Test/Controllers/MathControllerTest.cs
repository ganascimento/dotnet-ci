using Dotnet.CI.Api.Controllers;
using Dotnet.CI.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Dotnet.CI.Test.Controllers;

public class MathControllerTest
{
    private readonly MathController _controller;

    public MathControllerTest()
    {
        var mathServiceMock = new Mock<MathService>();
        _controller = new MathController(mathServiceMock.Object);
    }

    [Fact]
    public void Sum_ReturnCorrect()
    {
        var result = _controller.Sum(1, 2) as OkObjectResult;

        Assert.NotNull(result);
        Assert.Equal(200, result.StatusCode);
        Assert.Equal(3, Convert.ToDecimal(result.Value));
    }

    [Fact]
    public void Sub_ReturnCorrect()
    {
        var result = _controller.Sub(5, 2) as OkObjectResult;

        Assert.NotNull(result);
        Assert.Equal(200, result.StatusCode);
        Assert.Equal(Convert.ToDecimal(result.Value), 3);
    }

    [Fact]
    public void Mult_ReturnCorrect()
    {
        var result = _controller.Mult(3, 2) as OkObjectResult;

        Assert.NotNull(result);
        Assert.Equal(200, result.StatusCode);
        Assert.Equal(Convert.ToDecimal(result.Value), 6);
    }

    [Fact]
    public void Div_ReturnCorrect()
    {
        var result = _controller.Div(6, 2) as OkObjectResult;

        Assert.NotNull(result);
        Assert.Equal(200, result.StatusCode);
        Assert.Equal(Convert.ToDecimal(result.Value), 3);
    }

    [Fact]
    public void Div_ReturnError()
    {
        var result = _controller.Div(6, 0);

        Assert.IsType<BadRequestObjectResult>(result);
    }
}