using System;

namespace CSharp.Capitulo10.DelegateLambda.Testes
{
    internal delegate int EfetuarOperacao(int valor1, int valor2);

    internal static class Calculadora
    {
        private static int Somar(int x, int y)
        {
            return x + y;
        }

        private static int Subtrair(int x, int y)
        {
            return x - y;
        }

        private static int Multiplicar(int x, int y, int z)
        {
            return x * y * z;
        }

        public static EfetuarOperacao ObterOperacao(TipoOperacao tipoOperacao)
        {
            switch (tipoOperacao)
            {
                case TipoOperacao.Soma:
                    return Somar;
                case TipoOperacao.Subtracao:
                    return Subtrair;
                //case TipoOperacao.Divisao:
                //    break;
                //case TipoOperacao.Multiplicacao:
                //    return Multiplicar;
            }

            throw new Exception();
        }
    }
}