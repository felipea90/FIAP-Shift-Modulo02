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



        }
    }
}
