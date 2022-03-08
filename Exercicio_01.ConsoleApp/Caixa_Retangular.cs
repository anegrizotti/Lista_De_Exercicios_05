namespace Exercicio_01.ConsoleApp
{
    internal partial class Program
    {
        public class Caixa_Retangular
        {
            public double comprimento;
            public double altura;
            public double largura;

            public double Calcula_Volume()
            {
                double volume = comprimento*altura*largura;

                return volume;
            }
        }
    }
}
