using Xunit;
using PruevaCS;

namespace PruevaCS.Tests;

public class TestCalculadoraVacica
{
    [Fact]
    public void CalculadoraVacica_Constructor_Crea_Instancia()
    {
        var calc = new CalculadoraVacica(new Suma(), new Resta());
        Assert.NotNull(calc);
    }

    [Fact]
    public void CalculadoraVacica_Operacion1_Suma_Pasa()
    {
        var calc = new CalculadoraVacica(new Suma(), new Resta());
        Assert.Equal(7.0, calc.operacion1(3.0, 4.0));
    }

    [Fact]
    public void CalculadoraVacica_Operacion2_Resta_Pasa()
    {
        var calc = new CalculadoraVacica(new Suma(), new Resta());
        Assert.Equal(-1.0, calc.operacion2(3.0, 4.0));
    }

    [Fact]
    public void CalculadoraVacica_Operacion3_Resta_Invertida_Pasa()
    {
        var calc = new CalculadoraVacica(new Suma(), new Resta());
        Assert.Equal(1.0, calc.operacion3(3.0, 4.0)); // 4 - 3 = 1
    }

    [Fact]
    public void CalculadoraVacica_Operacion4_Retorna_Cero()
    {
        var calc = new CalculadoraVacica(new Suma(), new Resta());
        Assert.Equal(0.0, calc.operacion4(3.0, 4.0));
    }

    [Fact]
    public void CalculadoraVacica_Calcular_Suma_Pasa()
    {
        var calc = new CalculadoraVacica(new Suma(), new Resta());
        var suma = new Suma();
        Assert.Equal(7.0, calc.Calcular(suma, 3.0, 4.0));
    }

    [Fact]
    public void CalculadoraVacica_Calcular_Resta_Pasa()
    {
        var calc = new CalculadoraVacica(new Suma(), new Resta());
        var resta = new Resta();
        Assert.Equal(-1.0, calc.Calcular(resta, 3.0, 4.0));
    }

    [Fact]
    public void CalculadoraVacica_Calcular_Multiplicacion_Pasa()
    {
        var calc = new CalculadoraVacica(new Suma(), new Resta());
        var multiplicacion = new Multiplicacion();
        Assert.Equal(12.0, calc.Calcular(multiplicacion, 3.0, 4.0));
    }
}