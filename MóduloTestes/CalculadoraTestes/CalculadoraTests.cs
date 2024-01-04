using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    
    private CalculadoraImplementacao _calc;

     CalculadoraTests()
    {
        _calc = new CalculadoraImplementacao();
    }

    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange
        int num1 = 5;
        int num2 = 10;
        //Act
        int resultado = _calc.Somar(num1, num2);
        //Assert
        Assert.Equal(15, resultado);//Comparação de dois valores para ver se são iguais
    }
}
     [Fact]
     public void DeveVerificarSe4EhParERetornarTrue()
     {
         //Arrange
         int num1 = 4;
        
         //Act
         bool resultado = _calc.EhPar(num1);
         //Assert
         Assert.True(resultado);//Comparação de dois valores para ver se são iguais
     }

     [Theory]
     [InlineData(new int[] { 2, 4 })]
     [InlineData(new int[] { 6, 8, 10 })]


     public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
     {
        
         //Act / Assert
         Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));
     }


 