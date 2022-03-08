using System;

namespace Exercicio_02.ConsoleApp
{
    internal partial class Program
    {
        public class Testa_Fahrenheit
        {
            static void Main(string[] args)
            {
                Fahrenheit fahrenheit = new Fahrenheit();

                fahrenheit.graus_fahrenheit = 72;

                Console.WriteLine("A temperatura em graus Celsius é: {0}", fahrenheit.Converte_Para_Celsius());
            }
        }
    }
}
