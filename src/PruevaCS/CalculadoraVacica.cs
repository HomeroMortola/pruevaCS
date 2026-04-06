using PruevaCS;

public class CalculadoraVacica(Suma suma,IOperacion resta) : CalculadoraBase
{
    public override double Calcular(IOperacion operacion, double a, double b)
    {
        return operacion.Ejecutar(a, b);
    }
}