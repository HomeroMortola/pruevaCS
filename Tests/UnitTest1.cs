namespace PruevaCS.Tests;

using Xunit;
using PruevaCS;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var saludador = new Saludador();
        string texto = "Holaa";
        saludador.saludar(texto);  
        Assert.Equal(texto, saludador.mensaje);  
    }

    
}