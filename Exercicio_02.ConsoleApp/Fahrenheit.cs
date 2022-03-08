namespace Exercicio_02.ConsoleApp
{
    public class Fahrenheit
    {
        public double graus_fahrenheit;

        public double Converte_Para_Celsius ()
        {
            double celsius = 5 / 9 * (graus_fahrenheit - 32);

            return celsius;
        }
    }
}

