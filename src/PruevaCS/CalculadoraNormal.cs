using PruevaCS;

public class CalculadoraNormal : CalculadoraBase
{
    private readonly Suma _suma;
    private readonly Resta _resta;
    private readonly Multiplicacion _multiplicacion;
    private readonly Division _division;

    public CalculadoraNormal(Suma suma, Resta resta, Multiplicacion multiplicacion, Division division)
    {
        _suma = suma;
        _resta = resta;
        _multiplicacion = multiplicacion;
        _division = division;
    }

    public double Sumar(double a, double b)
    {
        return _suma.Ejecutar(a, b);
    }

    public double Restar(double a, double b)
    {
        return _resta.Ejecutar(a, b);
    }

    public double Multiplicar(double a, double b)
    {
        return _multiplicacion.Ejecutar(a, b);
    }

    public double Dividir(double a, double b)
    {
        return _division.Ejecutar(a, b);
    }

    public override double operacion1(double a, double b)
    {
        return _suma.Ejecutar(a, b);
    }

    public override double operacion2(double a, double b)
    {
        return _resta.Ejecutar(a, b);
    }
}
