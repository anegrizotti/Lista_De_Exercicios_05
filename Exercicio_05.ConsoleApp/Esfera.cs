namespace Exercicio_05.ConsoleApp
{
    public class Esfera
    {
        public double raio;

        public double Calcula_Volume_Esfera()
        {
            double raioAoCubo = raio * raio * raio;

            double volumeEsfera = (4/3)*(3.14*raioAoCubo);

            return volumeEsfera;
        }
    }
}
