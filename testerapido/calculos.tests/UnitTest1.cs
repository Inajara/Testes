namespace calculos.tests;

public class CalculadoraTest
{
    [Fact]
    public void Soma_DeveRetornarOValorCorreto()
    {
        //Arrange
        Calculadora c = new Calculadora();
        //Act
        var resultado = c.Soma(10, 20);
        //Assert - Verifica se o resultado é igual a 30       
        Assert.Equal(30, resultado);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    public void RestoDivisao_DeveRetornarZero(int value)
    {
        //Arrange
        Calculadora c = new Calculadora();
        //Act
        var resultado = c.RestoDivisao(12, value);
        //Verifica se o resto da divisão é 0
        Assert.Equal(0, resultado.resto);
    }

    [Fact]
    public void RestoDivisao_DeveRetornarOValorCorreto()
    {
        Calculadora c = new Calculadora();
        var resultado = c.RestoDivisao(10, 3);
        //Verifica se o quociente da divisão é 3 e o resto 1
        Assert.Equal(3, resultado.quociente);
        Assert.Equal(1, resultado.resto);
    }

    [Fact]
    public void Subtracao_DeveRetornarOValorCorreto()
    {
        Calculadora c = new Calculadora();
        var resultado = c.Subtracao(20, 10);
        //Verifica se o resultado é igual a 10
        Assert.Equal(10, resultado);
    }

    [Fact]
    public void Divisao_DeveRetornarOValorCorreto()
    {
        Calculadora c = new Calculadora();
        var resultado = c.Divisao(100, 10);
        //Verifica se o resultado é igual a 10
        Assert.Equal(10, resultado);
    }

    [Fact]
    public void Multiplicao_DeveRetornarOValorCorreto()
    {
        Calculadora c = new Calculadora();
        var resultado = c.Multiplicao(5, 2);
        //Verifica se o resultado é igual a 10
        Assert.Equal(10, resultado);
    }
}
