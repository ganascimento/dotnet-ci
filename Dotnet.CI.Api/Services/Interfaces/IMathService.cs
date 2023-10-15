namespace Dotnet.CI.Api.Services.Interfaces;

public interface IMathService
{
    decimal Sum(decimal value1, decimal value2);
    decimal Sub(decimal value1, decimal value2);
    decimal Mult(decimal value1, decimal value2);
    decimal Div(decimal value1, decimal value2);
}