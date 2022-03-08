namespace Exercicio_08.ConsoleApp
{
    internal partial class Program
    {
        public class Lata_Oleo
        {
            public double altura;
            public double raio;

            public double Calcula_Volume()
            {
                double volume = 3.14 * (raio*raio) * altura;

                return volume;
            }
        }
    }
}
