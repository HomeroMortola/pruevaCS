namespace PruevaCS
{
    public class CalculadoraCientifica : CalculadoraNormal
    {
        private readonly Potencia _potencia;
        private readonly Raiz _raiz;

        public CalculadoraCientifica(
            Suma suma,
            Resta resta,
            Multiplicacion multiplicacion,
            Division division,
            Potencia potencia,
            Raiz raiz)
            : base(suma, resta, multiplicacion, division)
        {
            _potencia = potencia;
            _raiz = raiz;
        }

        public double Potenciar(double a, double b)
        {
            return _potencia.Ejecutar(a, b);
        }

        public double ExtraerRaiz(double a, double b)
        {
            return _raiz.Ejecutar(a, b);
        }
    }
}
