using System;

namespace Exercicio_06.ConsoleApp
{
    internal partial class Program
    {
        public class Testa_Celsuis
        {
            static void Main(string[] args)
            {
                Celsius celsius = new Celsius();

                celsius.grausCelsius = 0;

                Console.WriteLine("A temperatura em graus Fahrenheit é: {0}", celsius.Converte_Para_Fahrenheit());
            }
        }
    }
}
