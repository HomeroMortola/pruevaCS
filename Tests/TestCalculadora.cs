using Xunit;
using PruevaCS;

namespace PruevaCS.Tests;

public class TestCalculadora
{
    [Fact]
    public void Calculadora_Sumar_Restar_Multiplicar_Pasan()
    {
        var calc = new CalculadoraVacica(new Suma(), new Resta());

    }

    [Fact]
    public void CalculadoraVacica_Suma_Pasa()
    {
        var suma = new Suma();
        var calc = new CalculadoraVacica(suma, new Resta());

        Assert.Equal(7.0, calc.Calcular(suma, 3.0, 4.0));
    }

    [Fact]
    public void CalculadoraVacica_Resta_Pasa()
    {
        var resta = new Resta();
        var calc = new CalculadoraVacica(new Suma(), resta);

        Assert.Equal(-1.0, calc.Calcular(resta, 3.0, 4.0));
    }

    [Fact]
    public void CalculadoraVacica_Multiplicacion_Pasa()
    {
        var multiplicacion = new Multiplicacion();
        var calc = new CalculadoraVacica(new Suma(), new Resta());

        Assert.Equal(12.0, calc.Calcular(multiplicacion, 3.0, 4.0));
    }
}