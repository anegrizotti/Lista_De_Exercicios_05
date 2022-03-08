using System;

namespace Exercicio_03.ConsoleApp
{
    public class Testa_Cilindro
    {
        static void Main(string[] args)
        {
            Cilindro cilindro = new Cilindro();

            cilindro.altura = 10;
            cilindro.areaBase = 10;

            Console.WriteLine("O volume do cilindro é: {0}", cilindro.Calcula_Volume_Cilindro());
        }
    }
}
