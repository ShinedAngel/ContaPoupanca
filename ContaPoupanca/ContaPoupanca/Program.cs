using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioCS
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca saldoPoupanca = new ContaPoupanca();
            ContaPoupanca.saldoPoupanca = 5000;

            ContaPoupanca poupador1 = new ContaPoupanca();
            ContaPoupanca.poupador1 = 2000;

            ContaPoupanca poupador2 = new ContaPoupanca();
            ContaPoupanca.poupador2 = 3000;

            ContaPoupanca taxaDeJurosAnual = new ContaPoupanca();
            ContaPoupanca.taxaDeJurosAnual = 0.04;

            ContaPoupanca AlterarTaxaDeJuros = new ContaPoupanca();
            ContaPoupanca.AlterarTaxaDeJuros = 0.05;

            ContaPoupanca CalcularJurosMensal = new ContaPoupanca();
            ContaPoupanca CalcularJurosAnual = new ContaPoupanca();

            Console.WriteLine("O saldo atual é: " + ContaPoupanca.saldoPoupanca);
            Console.WriteLine("A taxa de juros mensal em 4% é : " + CalcularJurosMensal.CalcularJurosMensal());
            Console.WriteLine("A taxa de juros mensal alterado para 5% é : " + CalcularJurosAnual.CalcularJurosAnual());
            Console.ReadLine();

            double valor1 = 2000;
            double valor2 = 3000;
            double porcento1 = 0.04 / 100.0;
            double porcento2 = 0.05 / 100.0;
            double resultado1 = valor1 + (porcento1 * valor1);
            double resultado2 = valor1 + (porcento2 * valor1);
            double resultado3 = valor2 + (porcento1 * valor2);
            double resultado4 = valor2 + (porcento2 * valor2);

            Console.WriteLine("O saldo do poupador 1 acrescidos em 4% de juros é igual a: " + resultado1);
            Console.ReadLine();

            Console.WriteLine("O saldo do poupador 1 acrescidos em 5% de juros é igual a: " + resultado2);
            Console.ReadLine();

            Console.WriteLine("O saldo do poupador 2 acrescidos em 4% de juros é igual a: " + resultado3);
            Console.ReadLine();

            Console.WriteLine("O saldo do poupador 2 acrescidos em 5% de juros é igual a: " + resultado4);
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
