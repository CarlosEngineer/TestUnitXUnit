using Calculator.Services;

namespace CalculatorTest;

public class CalculatorTest
{

    private CalculatorImp _calc;

    public CalculatorTest()
    {
        _calc =  new CalculatorImp();
    }

    [Fact] 
    public void DeveSomar5com10ERetornar15()
    {
        //arrange

        int num1 =  10;
        int num2 = 5;

        //act
        int Resultado = _calc.Somar(num1,num2); 

        //Assert    
        
        Assert.Equal(15, Resultado);
    }


    [Fact]
      public void DeveSomar15com15ERetornar30()
    {
        //arrange

        int num1 =  15;
        int num2 = 15;

        //act
        int Resultado = _calc.Somar(num1,num2); 

        //Assert    
        
        Assert.Equal(30, Resultado);
    }


    [Fact]
      public void VerificaSe4EParERetornaVerdadeiro()
    {
        //arrange

        int num1 =  4;

        //act
        bool Resultado = _calc.SeEPar(num1); 

        //Assert    
        
        Assert.True(Resultado);
    }

    [Theory]
    [InlineData ( new int []{ 2 ,4})]
    [InlineData ( new int []{ 8, 4, 8})]


    public void SeSaoParesRetornaTrue(int[] numeros)
    {
       

        //act/assert

       Assert.All(numeros, x => Assert.True(_calc.SeEPar(x)));
      

    }
}