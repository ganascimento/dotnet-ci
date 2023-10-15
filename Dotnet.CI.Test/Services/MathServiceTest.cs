using Dotnet.CI.Api.Services;
using Dotnet.CI.Api.Services.Interfaces;

namespace Dotnet.CI.Test.Services;

public class MathServiceTest
{
    private readonly IMathService _mathService;

    public MathServiceTest()
    {
        _mathService = new MathService();
    }

    [Fact]
    public void Sum_ReturnCorrect()
    {
        var result = _mathService.Sum(1, 2);

        Assert.Equal(3, result);
    }

    [Fact]
    public void Sub_ReturnCorrect()
    {
        var result = _mathService.Sub(3, 1);

        Assert.Equal(2, result);
    }

    [Fact]
    public void Mult_ReturnCorrect()
    {
        var result = _mathService.Mult(4, 3);

        Assert.Equal(12, result);
    }

    [Fact]
    public void Div_ReturnCorrect()
    {
        var result = _mathService.Div(10, 2);

        Assert.Equal(5, result);
    }

    [Fact]
    public void Div_ReturnErro()
    {
        Assert.Throws<DivideByZeroException>(() => _mathService.Div(10, 0));
    }
}