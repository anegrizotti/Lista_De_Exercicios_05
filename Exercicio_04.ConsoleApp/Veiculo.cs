namespace Exercicio_04.ConsoleApp
{
    internal partial class Program
    {
        public class Veiculo
        {
            public double kmInicial;
            public double kmFinal;
            public double consumo;

            public double Calcula_Consumo_Combustivel()
            {
                double distanciaPercorrida = kmFinal - kmInicial;

                double gastoCombustivel = distanciaPercorrida / consumo;

                return gastoCombustivel;
            }
        }
    }
}
