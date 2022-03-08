namespace Exercicio_06.ConsoleApp
{
    internal partial class Program
    {
        public class Celsius
        {
            public double grausCelsius;

            public double Converte_Para_Fahrenheit()
            {
                double conversao = (grausCelsius * (9 / 5)) + 32;

                return conversao;
            }
        }

    }
}
