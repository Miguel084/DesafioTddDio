using DesafioTddDio;

public class UnitTest1
{
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 5, 7)]
    public void Deve_SomarOsNumeros_ERetornarValorSomado(int num1, int num2, int res)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalc = calc.Somar(num1, num2);

        Assert.Equal(res, resultadoCalc);
    }
    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(2, 5, -3)]
    public void Deve_SubtrairOsNumeros_ERetornarValorSubtraido(int num1, int num2, int res)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalc = calc.Subtrair(num1, num2);

        Assert.Equal(res, resultadoCalc);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(2, 5, 10)]
    public void Deve_MultiplicarOsNumeros_ERetornarValorMultiplicado(int num1, int num2, int res)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalc = calc.Multiplicar(num1, num2);

        Assert.Equal(res, resultadoCalc);
    }

    [Theory]
    [InlineData(10, 2, 5)]
    [InlineData(12, 4, 3)]
    public void Deve_DividirOsNumeros_ERetornarValorDividido(int num1, int num2, int res)
    {
        Calculadora calc = new Calculadora();

        int resultadoCalc = calc.Dividir(num1, num2);

        Assert.Equal(res, resultadoCalc);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = new Calculadora();


        Assert.Throws<DivideByZeroException>(
            () => calc.Dividir(10, 0)
        );
    }

    [Fact]
    public void TestarHistoricoOperacoes()
    {
        Calculadora calc = new Calculadora();

        calc.Somar(1, 2);
        calc.Somar(2, 4);
        calc.Somar(6, 6);
        calc.Somar(8, 9);

        var list = calc.HistoricoOperacoes();

        Assert.NotEmpty(list);
        Assert.Equal(3, list.Count);
    }
}