using System;

namespace Exercicio_04.ConsoleApp
{
    internal partial class Program
    {
        public class Testa_Combustivel
        {
            static void Main(string[] args)
            {
                Combustivel combustivel = new Combustivel();

                combustivel.kmInicial = 0;
                combustivel.kmFinal = 100;
                combustivel.consumo = 10;

                Console.WriteLine("O consumo total de combustivel é: {0}", combustivel.Calcula_Consumo_Combustivel());

            }  
        }
    }
}
