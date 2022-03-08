using System;

namespace Exercicio_08.ConsoleApp
{
    internal partial class Program
    {
        public class Testa_Lata_Oleo
        {
            static void Main(string[] args)
            {
                Lata_Oleo lata = new Lata_Oleo();

                lata.altura = 10;
                lata.raio = 5;

                Console.WriteLine("O volume da lata de óleo é: {0}", lata.Calcula_Volume());
            }
        }

    }
}
