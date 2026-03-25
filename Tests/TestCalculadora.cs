namespace PruevaCS.Tests;

public class TestCalculadora1{
[Fact]
    public void Calculadora_Sumar_Restar_Multiplicar_Pasan()
    {
        var calc = new Calculadora();

        Assert.Equal(7, calc.Sumar(3, 4));
        Assert.Equal(-1, calc.Restar(3, 4));
        Assert.Equal(12, calc.Multiplicar(3, 4));

        Assert.Equal(0, calc.Sumar(-2, 2));
        Assert.Equal(-4, calc.Restar(-2, 2));
        Assert.Equal(-4, calc.Multiplicar(-2, 2));
    }
}