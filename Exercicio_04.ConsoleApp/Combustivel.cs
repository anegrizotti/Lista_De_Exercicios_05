namespace Exercicio_04.ConsoleApp
{
    internal partial class Program
    {
        public class Combustivel
        {
            public double kmInicial;
            public double kmFinal;
            public double consumo;

            public double Calcula_Consumo_Combustivel()
            {
                double distancia = kmFinal - kmInicial;

                double gastoCombustivel = distancia / consumo;

                return gastoCombustivel;
            }
        }
    }
}
