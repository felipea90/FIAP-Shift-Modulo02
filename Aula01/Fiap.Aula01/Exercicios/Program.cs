using System;

namespace Exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Projeto focados nos Exercícios do Módulo 02");

            //#################################

            //Exercicio 01
            Console.WriteLine("Cálculo do Custo final de um carro ao consumidor.");

            //Ler valor do veículo
            Console.WriteLine("Informe o valor de custo da fabricação:");
            float fabricacao = float.Parse(Console.ReadLine());

            //Realizar os cálculos
            float distribuidor = (float)(fabricacao * 0.29);
            float impostos = (float)(fabricacao * 0.46);
            decimal produtoFinal = (decimal)(fabricacao + distribuidor + impostos);

            //Imprimir valor final na tela
            Console.WriteLine($"O valor final do carro zero km será de R$: {produtoFinal}");

            //#################################

            //Exercício 02
            Console.WriteLine("Cálculo de comissão de Vendas.");

            double salario = 1500;
            double comissao;
            double venda;
            
            Console.WriteLine("Informe o valor final da venda:");
            venda = double.Parse(Console.ReadLine());

            if (venda <= 1500)
            {
                comissao = venda * 0.05;
                Console.WriteLine($"A comissão sobre a venda foi de R$ {comissao}");
                comissao = salario + (venda * 0.05);
                Console.WriteLine($"O Salário final será de R$ {comissao}");
            }
            else
            {
                comissao = 75 + ((venda -1500) * 0.1);
                Console.WriteLine($"A comissão sobre a venda foi de R$ {comissao}");
                comissao = salario + comissao;
                Console.WriteLine($"O Salário final será de R$ {comissao}");
            }

            //#################################

            //Exercício 03
            Console.WriteLine("Programa da Faculdade com as turmas A e B do curso de Farmácia.");

            int escolha, turmaQtd, turmaA=0, turmaB=0;
            double mediaA=0, mediaB=0, mediaTotal=0;

            Console.WriteLine("Informe a quantidade de alunos no curso de Farmácia:");
            turmaQtd = int.Parse(Console.ReadLine());

            double[] notasA = new double[turmaQtd], notasB = new double[turmaQtd];
            string[] alunosA = new string[turmaQtd], alunosB = new string[turmaQtd];

            Console.WriteLine("Informar a qual turma pertence o aluno.");

            for (int i=0; i < turmaQtd; i++)
            {
                Console.WriteLine("1 - Turma A \n2 - Turma B");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.WriteLine("Informar o nome do aluno:");
                    alunosA[i] = Console.ReadLine();

                    Console.WriteLine("Informar a nota do aluno:");
                    notasA[i] = double.Parse(Console.ReadLine());

                    mediaA = mediaA + notasA[i];

                    turmaA++;
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Informar o nome do aluno:");
                    alunosB[i] = Console.ReadLine();

                    Console.WriteLine("Informar a nota do aluno:");
                    notasB[i] = double.Parse(Console.ReadLine());

                    mediaB = mediaB + notasB[i];

                    turmaB++;
                }
                else
                {
                    Console.WriteLine("Opção Inválida.");
                    i--;
                }

            }

            mediaTotal = (mediaA + mediaB) / turmaQtd;
            Console.WriteLine($"A média de todos os alunos do curso de Farmácia foi {mediaTotal}");

            mediaA /= turmaA;
            Console.WriteLine($"A média dos alunos da Turma A foi {mediaA}");

            mediaB /= turmaB;
            Console.WriteLine($"A média dos alunos da Turma B foi {mediaB}");

            //#################################



        }
    }
}
