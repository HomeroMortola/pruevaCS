using PruevaCS;

public class CalculadoraVacica : CalculadoraBase
{
    private Suma _suma;
    private Resta _resta;

    public CalculadoraVacica(Suma suma, Resta resta)
    {
        _suma = suma;
        _resta = resta;
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