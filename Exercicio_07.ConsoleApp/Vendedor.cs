namespace Exercicio_07.ConsoleApp
{ 
    public class Vendedor
    {
        public double salarioBase;
        public double totalVendas;
        public int percentualComissao;

        public double Calcula_Salario_Final()
        {
            double salarioFinal = salarioBase + (totalVendas / percentualComissao);

            return salarioFinal;
        }
    }
}

