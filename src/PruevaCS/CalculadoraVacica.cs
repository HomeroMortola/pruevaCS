namespace PruevaCS
{
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

        public override double operacion3(double a, double b)
        { 
            return _resta.Ejecutar(b, a);
        }

        public override double operacion4(double a, double b){
            return 0;
        }

    }
}