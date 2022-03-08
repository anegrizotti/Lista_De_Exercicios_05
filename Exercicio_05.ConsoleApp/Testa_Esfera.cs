using System;

namespace Exercicio_05.ConsoleApp
{
    public class Testa_Esfera
    {
        static void Main(string[] args)
        {
            Esfera esfera = new Esfera();

            esfera.raio = 10;

            Console.WriteLine("O volume da esfera é: {0}", esfera.Calcula_Volume_Esfera());
        }
    }

}
