using System;

namespace Exercicio_01.ConsoleApp
{
    internal partial class Program
    {
        public class Testa_Caixa_Retangular
        {
            static void Main(string[] args)
            {
                Caixa_Retangular caixa_Retangular = new Caixa_Retangular();

                caixa_Retangular.comprimento = 10;
                caixa_Retangular.largura = 10;
                caixa_Retangular.altura = 10;

                Console.WriteLine("O volume da caixa retangular é: {0}", caixa_Retangular.Calcula_Volume());

            }
        }
    }
}
