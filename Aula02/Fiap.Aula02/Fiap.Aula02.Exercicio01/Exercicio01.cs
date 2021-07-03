using Fiap.Aula02.Exercicio01.Models;
using System;

namespace Fiap.Aula02.Exercicio01
{
    class Exercicio01
    {
        static void Main(string[] args)
        {
            Cor cor = new Cor();
            Carro carro = new Carro();
            
            Console.WriteLine("\n\nInforme agora os dados do seu veículo.\n\n");

            Console.WriteLine("Informe o Modelo do carro:");
            carro.Modelo = Console.ReadLine();

            Console.WriteLine("Informe a Cor carro:");
            cor.Nome = Console.ReadLine();

            Console.WriteLine("Informe o quanto de Vermelho (R)");
            cor.R = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o quanto de Verde (G)");
            cor.G = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o quanto de Azul (B)");
            cor.B = int.Parse(Console.ReadLine());

            carro.Cor = cor;

            Console.WriteLine("Informe a Placa do carro:");
            carro.Placa = Console.ReadLine();

            Console.WriteLine("Informe o Valor do carro:");
            carro.Valor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Ano do carro:");
            carro.Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Comprimento do carro:");
            carro.Comprimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe se o carro tem Ar Condicionado: \nTrue - Sim \nFalse - Não");
            carro.ArCond = bool.Parse(Console.ReadLine());
            
            Console.WriteLine("\nOs dados do seu carro são:\n");

            Console.WriteLine($"Modelo: {carro.Modelo}");
            Console.WriteLine($"Placa: {carro.Placa}");
            Console.WriteLine($"Cor: {carro.Cor.Nome}");
            Console.WriteLine($"Quantidade de Vermelho: {carro.Cor.R}");
            Console.WriteLine($"Quantidade de Verde: {carro.Cor.G}");
            Console.WriteLine($"Quantidade de Azul: {carro.Cor.B}");
            Console.WriteLine($"Valor: {carro.Valor}");
            Console.WriteLine($"Ano: {carro.Ano}");
            Console.WriteLine($"Comprimento: {carro.Comprimento} metros");
            Console.WriteLine($"Ar Condicionado: {carro.ArCond}");

        }
    }
}
