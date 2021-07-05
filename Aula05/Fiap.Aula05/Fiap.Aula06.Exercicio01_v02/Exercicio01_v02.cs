using Fiap.Aula06.Exercicio01_02.Models;
using System;

namespace Fiap.Aula06.Exercicio01_v02
{
    class Exercicio01_v02
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a formação");
            Console.WriteLine("1 - Tecnologo \n2 - Bacharelado \n3 - Licenciatura");
            int opcaoCurso = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a sua formação");
            string nomeFormacao = Console.ReadLine();

            Formacao formacao;

            if (opcaoCurso ==2)
            {
                Console.WriteLine("Informe o título do TCC");
                string projeto = Console.ReadLine();

                Console.WriteLine("Informe a carga horário do estágio");
                int estagio = int.Parse(Console.ReadLine());

                formacao = new Bacharelado(nomeFormacao, estagio)
                {
                    ProjetoConclusao = projeto
                };
            }
            else if (opcaoCurso == 1)
            {
                formacao = new Tecnologo(nomeFormacao)
                {
                    PlanoEstendido = true
                };
            }
            else
            {
                formacao = new Formacao(nomeFormacao);
            }

            //Exibir os dados do objeto
            Console.WriteLine(formacao);

            int opcao;
            do
            {
                Console.WriteLine("1 - Calcular Mensalidade \n2 - Calcular Média \n0 - SAIR");
                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        Console.WriteLine($"A mensalidade é R$ {formacao.CalcularMensalidade()}");
                    break;

                    case 2:
                        Console.WriteLine("Digite a nota 1");
                        float nota1 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a nota 2");
                        float nota2 = float.Parse(Console.ReadLine());

                        Console.WriteLine("Digite a nota 3");
                        float nota3 = float.Parse(Console.ReadLine());

                        Console.WriteLine($"A média é {formacao.CalcularMedia(nota1, nota2, nota3)}");
                    break;

                    case 0:
                        Console.WriteLine("SAINDO...");
                    break;

                    default:
                        Console.WriteLine("Opção Inválida...");
                    break;
                }
            } while (opcao != 0);
        }
    }
}


