public class Division : IOperacion
{
    public double Ejecutar(double a, double b)
    {
        if (b == 0)
            throw new DivideByZeroException("No se puede dividir por cero.");

        return a / b;
    }
}
