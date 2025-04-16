using Xunit;
using CalculadoraApp;

namespace CalculadoraTest;

public class CalculadoraTests
{
    Calculadora calc = new Calculadora();

    [Fact]
    public void TesteSomar() => Assert.Equal(5, calc.Somar(2, 3));

    [Fact]
    public void TesteSubtrair() => Assert.Equal(1, calc.Subtrair(4, 3));

    [Fact]
    public void TesteMultiplicar() => Assert.Equal(15, calc.Multiplicar(3, 5));

    [Fact]
    public void TesteDividir() => Assert.Equal(2, calc.Dividir(10, 5));

    [Fact]
    public void TestePotenciar() => Assert.Equal(16, calc.Potenciar(2, 4));

    [Fact]
    public void TesteDivisaoPorZero() =>
        Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 0));
}
