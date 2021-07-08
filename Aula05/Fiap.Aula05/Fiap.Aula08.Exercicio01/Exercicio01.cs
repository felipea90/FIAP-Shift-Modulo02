using Fiap.Aula08.Exercicio01.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Fiap.Aula08.Exercicio01
{
    class Exercicio01
    {
        static void Main(string[] args)
        {
            //Criar uma lista de Alunos
            IList<Aluno> listaAluno = new List<Aluno>();

            do
            {
                Console.WriteLine("SISTEMA ESCOLAR");

                //Ler os dados do aluno
                Console.WriteLine("\nInforme o nome do aluno");
                var nome = Console.ReadLine();

                Console.WriteLine("\nInforme a nota do aluno");
                var nota = float.Parse(Console.ReadLine());

                Console.WriteLine("\nInforme o gênero do aluno");
                Console.WriteLine("0 - Feminino \n1 - Masculino \n2 - Outros");
                //Transforma uma string em um valor do Enum, GENERO
                //cast -> forçar o objeto ser do tipo GENERO
                Genero genero = (Genero)Enum.Parse(typeof(Genero), Console.ReadLine());

                //Instanciar o aluno com os valores
                var aluno = new Aluno(nome, nota, genero);

                //Adicionar o objeto na lista
                listaAluno.Add(aluno);

                Console.WriteLine("Adicionar outro aluno? (True / False)");

            }
            
            while (bool.Parse(Console.ReadLine()));

            float somaNotas = 0;

            foreach (var item in listaAluno)
            {
                somaNotas += item.Nota;
            }

            //Listar os dados preenchidos e adicionados na lista
            Console.WriteLine("DADOS DOS ALUNOS\n");

            //Exibir o total de alunos
            Console.WriteLine($"O total de alunos cadastrados é de {listaAluno.Count} \n");

            //Exibir a Média das notas
            //Console.WriteLine($"A Média geral de todas as notas é {somaNotas / listaAluno.Count} \n");
            Console.WriteLine($"A Média geral de todas as notas é {listaAluno.Average(a => a.Nota)} \n");

            //Porcentagem de alunos por Gênero
            Console.WriteLine("Divisão de gêneros cadastrados:");
            Console.WriteLine("A Porcentagem de Gênero Feminino é " + (float) listaAluno.Count(a => a.Genero == Genero.Feminino) / listaAluno.Count * 100 + "%");
            Console.WriteLine("A Porcentagem de Gênero Masculino é " + (float) listaAluno.Count(a => a.Genero == Genero.Masculino) / listaAluno.Count * 100 + "%");
            Console.WriteLine("A Porcentagem de Gênero Outros é " + (float) listaAluno.Count(a => a.Genero == Genero.Outros) / listaAluno.Count * 100 + "%");

            //CTRL + D -> Duplica a linha
            //CTRL + L -> Apaga a linha

            int opcao;

            do
            {
                Console.WriteLine("\nMENU");
                Console.WriteLine("1 - Exibir os nomes e médias de todos os alunos");
                Console.WriteLine("2 - Exibir os nomes dos alunos com média maior do que 6.0");
                Console.WriteLine("3 - Exibir os todos os alunos por gênero");
                Console.WriteLine("4 - Pesquisa dos alunos por gênero");
                Console.WriteLine("0 - SAIR DO SISTEMA\n");

                opcao = int.Parse(Console.ReadLine());

                switch(opcao)
                {
                    case 1:
                        for (int i = 0; i < listaAluno.Count; i++)
                        {
                            Console.WriteLine("Nome: " + listaAluno[i].Nome);
                            Console.WriteLine("Nota: " + listaAluno[i].Nota);

                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        Console.WriteLine("Alunos com a nota acima da Média 6.0");

                        for (int i = 0; i < listaAluno.Count; i++)
                        {
                            if (listaAluno[i].Nota > 6)
                            {
                                Console.WriteLine("Nome: " + listaAluno[i].Nome);
                            }
                        }
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.WriteLine("Gênero Feminino");
                        var listaF = listaAluno.Where(a => a.Genero == Genero.Feminino).ToList();
                        foreach (var item in listaF)
                        {
                            Console.WriteLine($"Nome: {item.Nome}");
                        }

                        Console.WriteLine();

                        Console.WriteLine("Gênero Masculino");
                        var listaM = listaAluno.Where(a => a.Genero == Genero.Masculino).ToList();
                        foreach (var item in listaM)
                        {
                            Console.WriteLine($"Nome: {item.Nome}");
                        }

                        Console.WriteLine();

                        Console.WriteLine("Gênero Outros");
                        var listaO = listaAluno.Where(a => a.Genero == Genero.Outros).ToList();
                        foreach (var item in listaO)
                        {
                            Console.WriteLine($"Nome: {item.Nome}");
                        }

                        Console.WriteLine();
                        break;

                    case 4:
                        Console.WriteLine("Pesquisa por Gênero");
                        Console.WriteLine("Informe o item de pesquisa: ");
                        Console.WriteLine("0 - Feminino \n1 - Masculino \n2 - Outros");

                        Genero genero = (Genero)Enum.Parse(typeof(Genero), Console.ReadLine(), true);

                        var lista = listaAluno.Where(a => a.Genero == genero).ToList();

                        foreach (var item in lista)
                        {
                            Console.WriteLine($"Nome: {item.Nome}");
                        }

                        Console.WriteLine();
                        break;

                    case 0:
                        Console.WriteLine("SAINDO...");
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");

                        Console.WriteLine();
                        break;
                }
            }
            while (opcao != 0);
        }
    }
}
