using Xunit;
using PruevaCS;

namespace PruevaCS.Tests;

public class TestCalculadora
{
    [Fact]
    public void Calculadora_Sumar_Restar_Multiplicar_Pasan()
    {
        var calc = new CalculadoraVacica();

    }

    [Fact]
    public void CalculadoraVacica_Suma_Pasa()
    {
        var calc = new CalculadoraVacica();
        var suma = new Suma();

        Assert.Equal(7.0, calc.Calcular(suma, 3.0, 4.0));
    }

    [Fact]
    public void CalculadoraVacica_Resta_Pasa()
    {
        var calc = new CalculadoraVacica();
        var resta = new Resta();

        Assert.Equal(-1.0, calc.Calcular(resta, 3.0, 4.0));
    }

    [Fact]
    public void CalculadoraVacica_Multiplicacion_Pasa()
    {
        var calc = new CalculadoraVacica();
        var multiplicacion = new Multiplicacion();

        Assert.Equal(12.0, calc.Calcular(multiplicacion, 3.0, 4.0));
    }
}