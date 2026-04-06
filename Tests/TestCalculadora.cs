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

    [Fact]
    public void CalculadoraNormal_Suma_Pasa()
    {
        var calc = new CalculadoraNormal(new Suma(), new Resta(), new Multiplicacion(), new Division());
        Assert.Equal(7.0, calc.Sumar(3.0, 4.0));
    }

    [Fact]
    public void CalculadoraNormal_Resta_Pasa()
    {
        var calc = new CalculadoraNormal(new Suma(), new Resta(), new Multiplicacion(), new Division());
        Assert.Equal(-1.0, calc.Restar(3.0, 4.0));
    }

    [Fact]
    public void CalculadoraNormal_Multiplicacion_Pasa()
    {
        var calc = new CalculadoraNormal(new Suma(), new Resta(), new Multiplicacion(), new Division());
        Assert.Equal(12.0, calc.Multiplicar(3.0, 4.0));
    }

    [Fact]
    public void CalculadoraNormal_Division_Pasa()
    {
        var calc = new CalculadoraNormal(new Suma(), new Resta(), new Multiplicacion(), new Division());
        Assert.Equal(2.0, calc.Dividir(8.0, 4.0));
    }

    [Fact]
    public void CalculadoraNormal_Division_Por_Cero_Lanza_Excepcion()
    {
        var calc = new CalculadoraNormal(new Suma(), new Resta(), new Multiplicacion(), new Division());
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(8.0, 0.0));
    }

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