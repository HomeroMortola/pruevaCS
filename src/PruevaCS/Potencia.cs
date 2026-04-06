using System;

namespace PruevaCS
{
    public class Potencia : IOperacion
    {
        public double Ejecutar(double a, double b)
        {
            return Math.Pow(a, b);
        }
    }
}
