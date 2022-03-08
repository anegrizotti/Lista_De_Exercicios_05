using System;

namespace Exercicio_10.ConsoleApp
{
    public class Testa_Media_Ponderada
    {
        static void Main(string[] args)
        {
            Media_Ponderada media_Ponderada = new Media_Ponderada();

            media_Ponderada.nota1 = 10;
            media_Ponderada.peso1 = 0.7;
            media_Ponderada.nota2 = 8;
            media_Ponderada.peso2 = 0.3;

            Console.WriteLine("A média ponderada é: {0}", media_Ponderada.Calcula_Media());
        }
    }

}
