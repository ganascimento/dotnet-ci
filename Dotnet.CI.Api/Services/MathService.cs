using Dotnet.CI.Api.Services.Interfaces;

namespace Dotnet.CI.Api.Services;

public class MathService : IMathService
{
    public decimal Sum(decimal value1, decimal value2)
    {
        return value1 + value2;
    }

    public decimal Sub(decimal value1, decimal value2)
    {
        return value1 - value2;
    }

    public decimal Mult(decimal value1, decimal value2)
    {
        return value1 * value2;
    }

    public decimal Div(decimal value1, decimal value2)
    {
        if (value2 == 0) throw new DivideByZeroException("Error to divide by 0!");
        return value1 / value2;
    }
}