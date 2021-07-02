using Exercicio01.Models;
using System;

namespace Exercicio01
{
    class Exercicio01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa Conta Corrente, Conta Poupança e Cliente\n");

            //var -> define uma variável "genérica" que recebe o tipo de valor atribuído a ela

            //Ler os dados do cliente

            Console.WriteLine("Digite o nome do Cliente");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF");
            var cpf = Console.ReadLine();

            Console.WriteLine("Informe o Telefone");
            var telefone = Console.ReadLine();

            //Ler os dados da conta poupança (número)

            Console.WriteLine("Informe o número da conta poupança");
            var numeroPoupanca = double.Parse(Console.ReadLine());

            //Ler os dados da conta corrente (número, especial (se sim, juros e limite))

            Console.WriteLine("Informe o número da conta corrente");
            var numeroCc = double.Parse(Console.ReadLine());

            Console.WriteLine("A conta corrente é especial?");
            var especial = bool.Parse(Console.ReadLine());


            //Instanciar os objetos e atribuir os valores aos seus atributos (propriedades)
            var cliente = new Cliente();
            cliente.Nome = nome;
            cliente.Telefone = telefone;
            cliente.Cpf = cpf;

            var cp = new ContaPoupanca();
            cp.Numero = numeroPoupanca;

            var cc = new ContaCorrente();
            cc.Numero = numeroCc;
            cc.Cliente = cliente;
            cc.ContaPoupanca = cp;
            cc.Especial = especial;

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
                        cc.Depositar(valor);
                        Console.WriteLine($"O saldo é {cc.Saldo} e o saldo total é {cc.RetornarSaldoTotal()}");
                    break;

                    case 2:
                        Console.WriteLine("Informe o valor a ser retirado");
                        valor = decimal.Parse(Console.ReadLine());
                        cc.Retirar(valor);
                        Console.WriteLine($"O saldo é {cc.Saldo} e o saldo total é {cc.RetornarSaldoTotal()}");
                        break;

                    case 3:
                        Console.WriteLine("Informe o valor a ser transferido para poupança");
                        valor = decimal.Parse(Console.ReadLine());
                        cc.TransferirParaPoupanca(valor);
                        Console.WriteLine($"O saldo da CC é {cc.Saldo} \nO saldo total da CC é {cc.RetornarSaldoTotal()} \nO saldo da Poupança é {cp.Saldo}");
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
