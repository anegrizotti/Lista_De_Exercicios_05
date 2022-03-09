using System;

namespace Exercicio_04.ConsoleApp
{
    internal partial class Program
    {
        public class Testa_Veiculo
        {
            static void Main(string[] args)
            {
                Veiculo veiculo = new Veiculo();

                veiculo.kmInicial = 0;
                veiculo.kmFinal = 100;
                veiculo.consumo = 10;

                Console.WriteLine("O consumo total de combustivel é: {0}", veiculo.Calcula_Consumo_Combustivel());

            }  
        }
    }
}
