namespace Exercicio_10.ConsoleApp
{
    public class Media_Ponderada
    {
        public double nota1;
        public double nota2;
        public double peso1;
        public double peso2;

        public double Calcula_Media()
        {
            double mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

            return mediaPonderada;
        }
    }

}
