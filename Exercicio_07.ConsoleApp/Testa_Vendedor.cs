using System;

namespace Exercicio_07.ConsoleApp
{
    public class Testa_Vendedor
    {
        static void Main(string[] args)
        {
            Vendedor salario = new Vendedor();

            salario.salarioBase = 1500;
            salario.totalVendas = 1000;
            salario.percentualComissao = 10;

            Console.WriteLine("O salário final do funcionário é: {0}", salario.Calcula_Salario_Final());

        }
    }

}
