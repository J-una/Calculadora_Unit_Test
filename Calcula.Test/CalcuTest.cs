using Calcu;

namespace Calcula.Test
{
    public class CalcuTest
    {
        [Fact(DisplayName ="Soma de dois Numeros")]
        public void Somar()
        {
            Assert.Equal(20, FuncoesCalculadora.Somar(11, 9));
        }

        [Fact(DisplayName ="Subtracao de dois numeros")]
        public void Subtrair()
        {
            Assert.Equal(45, FuncoesCalculadora.Subtrair(56, 11));
        }

        [Fact(DisplayName ="Multiplicao de dois numeros")]
        public void Multiplicar()
        {
            Assert.Equal(200, FuncoesCalculadora.Multiplicar(20, 10));
        }

        [Fact(DisplayName ="Divisao de dois numeros")]
        public void Dividir()
        {
            Assert.Equal(20, FuncoesCalculadora.Dividir(40, 2));
        }

    }
}