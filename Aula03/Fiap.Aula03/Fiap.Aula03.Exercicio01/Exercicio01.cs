using Fiap.Aula03.Exercicio01.Models;
using System;

namespace Fiap.Aula03.Exercicio01
{
    public class Exercicio01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Conta Corrente, Conta Poupança e Cliente\n");

            Console.WriteLine("Digite o nome do Cliente");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF");
            var cpf = Console.ReadLine();

            Console.WriteLine("Informe o Telefone");
            var telefone = Console.ReadLine();

            Console.WriteLine("Informe o número da conta poupança");
            var numeroPoupanca = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o número da conta corrente");
            var numeroCc = double.Parse(Console.ReadLine());

            Console.WriteLine("A conta corrente é especial?");
            var especial = bool.Parse(Console.ReadLine());

            var cliente = new Cliente(nome: nome, cpf: cpf, telefone: telefone);

            var cp = new ContaPoupanca(numero: numeroPoupanca);

            var cc = new ContaCorrente(numeroCc, cliente, cp, especial);

            if (especial)
            {
                Console.WriteLine("Informe o limte");
                var limite = decimal.Parse(Console.ReadLine());

                Console.WriteLine("Digite os juros");
                var juros = double.Parse(Console.ReadLine());

                cc.Limite = limite;
                cc.Juros = juros;
            }

            int opcao;

            do
            {
                Console.WriteLine("\nMENU\n");
                Console.WriteLine("1 - Depositar");
                Console.WriteLine("2 - Retirar");
                Console.WriteLine("3 - Transferir");
                Console.WriteLine("4 - Calcular o valor da taxa de juros");
                Console.WriteLine("5 - Consultar o Saldo CC");
                Console.WriteLine("6 - Consultar o Saldo CP");
                Console.WriteLine("0 - SAIR\n");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe o valor para depósito");
                        var valor = decimal.Parse(Console.ReadLine());
                        try
                        {
                            cc.Depositar(valor);
                            Console.WriteLine($"O saldo é {cc.Saldo} e o saldo total é {cc.RetornarSaldoTotal()}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 2:
                        Console.WriteLine("Informe o valor a ser retirado");
                        valor = decimal.Parse(Console.ReadLine());
                        try
                        {
                            cc.Retirar(valor);
                            Console.WriteLine($"O saldo é {cc.Saldo} e o saldo total é {cc.RetornarSaldoTotal()}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 3:
                        Console.WriteLine("Informe o valor a ser transferido para poupança");
                        valor = decimal.Parse(Console.ReadLine());
                        try
                        {
                            cc.TransferirParaPoupanca(valor);
                            Console.WriteLine($"O saldo da CC é {cc.Saldo} \nO saldo total da CC é {cc.RetornarSaldoTotal()} \nO saldo da Poupança é {cp.Saldo}");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;

                    case 4:
                        if (especial)
                        {
                            Console.WriteLine("Informe a quantidade de dias");
                            var dias = int.Parse(Console.ReadLine());
                            Console.WriteLine($"O valor do Juros é {cc.CalcularValorTaxaJuros(dias)}");
                        }
                        else
                        {
                            Console.WriteLine("Você não tem conta corrente Especial.");
                        }
                        break;

                    case 5:
                        Console.WriteLine($"o Saldo da sua Conta Corrente é R$ {cc.Saldo}");
                        break;

                    case 6:
                        Console.WriteLine($"o Saldo da sua Conta Poupança é R$ {cp.Saldo}");
                        break;

                    case 0:
                        Console.WriteLine("Saindo...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
            while (opcao != 0);
        }
    }
}