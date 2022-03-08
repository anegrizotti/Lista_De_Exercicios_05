namespace Exercicio_09.ConsoleApp
{
    public class Media_Harmonica
    {
        public double nota1;
        public double nota2;
        public double nota3;
        public double nota4;

        public double Calcula_Media()
        {
            double mediaHarmonica = (4 / ((1 / nota1) + (1 / nota2) + (1 / nota3) + (1 / nota4)));

            return mediaHarmonica;
        }
    }


}
