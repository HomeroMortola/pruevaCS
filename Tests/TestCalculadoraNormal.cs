using Xunit;
using PruevaCS;

namespace PruevaCS.Tests;

public class TestCalculadoraNormal
{
    [Fact]
    public void CalculadoraNormal_Suma_Pasa()
    {
        var calc = new CalculadoraNormal(new Suma(), new Resta(), new Multiplicacion(), new Division());
        Assert.Equal(7.0, calc.operacion1(3.0, 4.0));
    }

    [Fact]
    public void CalculadoraNormal_Resta_Pasa()
    {
        var calc = new CalculadoraNormal(new Suma(), new Resta(), new Multiplicacion(), new Division());
        Assert.Equal(-1.0, calc.operacion2(3.0, 4.0));
    }

    [Fact]
    public void CalculadoraNormal_Multiplicacion_Pasa()
    {
        var calc = new CalculadoraNormal(new Suma(), new Resta(), new Multiplicacion(), new Division());
        Assert.Equal(12.0, calc.operacion3(3.0, 4.0));
    }

    [Fact]
    public void CalculadoraNormal_Division_Pasa()
    {
        var calc = new CalculadoraNormal(new Suma(), new Resta(), new Multiplicacion(), new Division());
        Assert.Equal(2.0, calc.operacion4(8.0, 4.0));
    }

    [Fact]
    public void CalculadoraNormal_Division_Por_Cero_Lanza_Excepcion()
    {
        var calc = new CalculadoraNormal(new Suma(), new Resta(), new Multiplicacion(), new Division());
        Assert.Throws<DivideByZeroException>(() => calc.operacion4(8.0, 0.0));
    }
}