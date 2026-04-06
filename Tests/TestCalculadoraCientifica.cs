using Xunit;
using PruevaCS;

namespace PruevaCS.Tests;

public class TestCalculadoraCientifica
{
    [Fact]
    public void CalculadoraCientifica_Potencia_Pasa()
    {
        var calc = new CalculadoraCientifica(new Suma(), new Resta(), new Multiplicacion(), new Division(), new Potencia(), new Raiz());
        Assert.Equal(8.0, calc.Potenciar(2.0, 3.0));
    }

    [Fact]
    public void CalculadoraCientifica_Raiz_Pasa()
    {
        var calc = new CalculadoraCientifica(new Suma(), new Resta(), new Multiplicacion(), new Division(), new Potencia(), new Raiz());
        Assert.Equal(3.0, calc.ExtraerRaiz(9.0, 2.0));
    }

    [Fact]
    public void CalculadoraCientifica_Raiz_Indice_Cero_Lanza_Excepcion()
    {
        var calc = new CalculadoraCientifica(new Suma(), new Resta(), new Multiplicacion(), new Division(), new Potencia(), new Raiz());
        Assert.Throws<ArgumentException>(() => calc.ExtraerRaiz(9.0, 0.0));
    }
}