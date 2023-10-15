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

        Assert.Equal(result, 3);
    }

    [Fact]
    public void Sub_ReturnCorrect()
    {
        var result = _mathService.Sub(3, 1);

        Assert.Equal(result, 2);
    }

    [Fact]
    public void Mult_ReturnCorrect()
    {
        var result = _mathService.Mult(4, 3);

        Assert.Equal(result, 12);
    }

    [Fact]
    public void Div_ReturnCorrect()
    {
        var result = _mathService.Div(10, 2);

        Assert.Equal(result, 5);
    }

    [Fact]
    public void Div_ReturnErro()
    {
        Assert.Throws<DivideByZeroException>(() => _mathService.Div(10, 0));
    }
}