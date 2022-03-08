using System;

namespace Exercicio_09.ConsoleApp
{
    public class Testa_Media_Harmonica
    {
        static void Main(string[] args)
        {
            Media_Harmonica media_Harmonica = new Media_Harmonica();

            media_Harmonica.nota1 = 10;
            media_Harmonica.nota2 = 9;
            media_Harmonica.nota3 = 8;
            media_Harmonica.nota4 = 7;

            Console.WriteLine("A média harmonica é: {0}", media_Harmonica.Calcula_Media());
        }
    }

}
