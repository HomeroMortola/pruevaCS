using System;

namespace PruevaCS
{
    public class Raiz : IOperacion
    {
        public double Ejecutar(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("El índice de la raíz no puede ser 0.");

            return Math.Pow(a, 1.0 / b);
        }
    }
}
