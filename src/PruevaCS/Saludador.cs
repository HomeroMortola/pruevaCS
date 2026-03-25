

namespace PruevaCS
{   
    using System;
    public class Saludador
    {
        public string mensaje="";

        public void saludar(string m)
        {
        this.mensaje = m;
        Console.WriteLine(mensaje);

        }

    }
}
