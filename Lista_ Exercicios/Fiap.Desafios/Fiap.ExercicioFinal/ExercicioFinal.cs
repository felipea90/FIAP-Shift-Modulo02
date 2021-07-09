using Fiap.ExercicioFinal.ExceptionModel;
using Fiap.ExercicioFinal.Models;
using System;
using System.Collections.Generic;

namespace Fiap.ExercicioFinal
{
    class ExercicioFinal
    {
        static void Main(string[] args)
        {
            //Clientes
            var listaClientes = new List<Cliente>();

            Console.WriteLine("Informe a quantidade de clientes");
            var qtd = int.Parse(Console.ReadLine());

            for (int i = 0; i < qtd; i++)
            {
                Console.WriteLine("\nInforme o ID do cliente");
                var id = long.Parse(Console.ReadLine());

                Console.WriteLine("\nInforme o Nome do cliente");
                var nome = Console.ReadLine();

                Console.WriteLine("\nInforme o CPF do cliente");
                var cpf = Console.ReadLine();

                Cliente cliente = new Cliente(id, nome)
                {
                    Cpf = cpf
                };

                listaClientes.Add(cliente);
            }

            //Conta Corrente
            Console.WriteLine("\nDigite o número da conta corrente");
            var numeroCc = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a agência da conta corrente");
            var agenciaCc = int.Parse(Console.ReadLine());

            var dataAbertura = DateTime.Now;

            Console.WriteLine("\nInforme o tipo de conta corrente");
            Console.WriteLine("0 - Comum \n1 - Especial \n2 - Premium");
            TipoConta tipo = (TipoConta)Enum.Parse(typeof(TipoConta), Console.ReadLine());

            ContaCorrente cc = new ContaCorrente(
                agencia: agenciaCc,
                numero: numeroCc,
                clientes: listaClientes,
                tipo: tipo)
            {
                DataAbertura = dataAbertura
            };

            Console.WriteLine($"\nDados Conta Corrente: \n{cc}");

            //Conta Poupança
            Console.WriteLine("\nDigite o número da conta Poupança");
            var numeroCp = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDigite a agência da conta Poupança");
            var agenciaCp = int.Parse(Console.ReadLine());

            dataAbertura = DateTime.Now;

            Console.WriteLine("\nInforme a Taxa conta Poupança");
            var taxa = decimal.Parse(Console.ReadLine());

            ContaPoupanca cp = new ContaPoupanca(
                agencia: agenciaCc,
                numero: numeroCc,
                clientes: listaClientes,
                taxa: taxa)
            {
                DataAbertura = dataAbertura,
                Taxa = taxa
            };

            Console.WriteLine($"\nDados Conta Poupança: \n{cp}");

            //Menu da Aplicação
            int opcao;

            do
            {
                Console.WriteLine("\nMENU\n");
                Console.WriteLine("1. Depositar na Conta Corrente");
                Console.WriteLine("2. Retirar da Conta Corrente");
                Console.WriteLine("3. Depositar na Conta Poupança");
                Console.WriteLine("4. Retirar da Conta Poupança");
                Console.WriteLine("5. Exibir os dados das duas Contas");
                Console.WriteLine("6. Calcular o Retorno do Investimento");
                Console.WriteLine("0. SAIR");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Informe o valor do Depósito");
                        var valor = decimal.Parse(Console.ReadLine());

                        cc.Depositar(valor);

                        Console.WriteLine($"Novo Saldo da Conta Corrente: \nR$ {cc.Saldo}");

                        Console.WriteLine();
                        break;

                    case 2:
                        try
                        {
                            Console.WriteLine("Informe o valor do Saque");
                            valor = decimal.Parse(Console.ReadLine());

                            cc.Retirar(valor);

                            Console.WriteLine($"Novo Saldo da Conta Corrente: \nR$ {cc.Saldo}");
                        }
                        catch (MessageException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Informe o valor do Depósito");
                        valor = decimal.Parse(Console.ReadLine());

                        cp.Depositar(valor);

                        Console.WriteLine($"Novo Saldo da Conta Corrente: \nR$ {cp.Saldo}");

                        Console.WriteLine();
                        break;

                    case 4:
                        try
                        {
                            Console.WriteLine("Informe o valor do Saque");
                            valor = decimal.Parse(Console.ReadLine());

                            cp.Retirar(valor);

                            Console.WriteLine($"Novo Saldo da Conta Corrente: \nR$ {cp.Saldo}");
                        }
                        catch (MessageException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine($"Conta Corrente: \n{cc}");
                        Console.WriteLine();
                        Console.WriteLine($"Conta Poupança: \n{cp}");

                        Console.WriteLine();
                        break;

                    case 6:
                        Console.WriteLine($"O valor de investimento é R$ {cp.CalcularRetornoInvestimento()}");

                        Console.WriteLine();
                        break;

                    case 0:
                        Console.WriteLine("\nSAINDO DO SISTEMA...");
                        break;

                    default:
                        Console.WriteLine("\nOpção Inválida. \nTente Novamente.");
                        break;
                }
            }
            while (opcao != 0);

        }
    }
}
