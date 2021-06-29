using Fiap.Aula02.Exercicio01.Models;
using System;

namespace Fiap.Aula02.Exercicio01
{
    class Exercicio01
    {
        static void Main(string[] args)
        {
            //Instanciando as Classes

            Carro carro1 = new Carro();
            Carro carro2 = new Carro();

            Cor cor1 = new Cor();
            Cor cor2 = new Cor();

            cor1.Nome = "Vermelho";
            cor1.R = 238;
            cor1.G = 0;
            cor1.B = 0;

            carro1.Modelo = "Fiesta";
            carro1.Placa = "FTB5310";
            carro1.Valor = 50000;
            carro1.Cor = cor1;
            carro1.Ano = 2020;
            carro1.Comprimento = 2.5;
            carro1.ArCond = true;

            Console.WriteLine("Os dados do carro armazenado são:\n");

            Console.WriteLine($"Modelo: {carro1.Modelo}");
            Console.WriteLine($"Placa: {carro1.Placa}");
            Console.WriteLine($"Cor: {carro1.Cor.Nome}");
            Console.WriteLine($"Quantidade de Vermelho: {carro1.Cor.R}");
            Console.WriteLine($"Quantidade de Verde: {carro1.Cor.G}");
            Console.WriteLine($"Quantidade de Azul: {carro1.Cor.B}");
            Console.WriteLine($"Valor: {carro1.Valor}");
            Console.WriteLine($"Ano: {carro1.Ano}");
            Console.WriteLine($"Comprimento: {carro1.Comprimento} metros");
            Console.WriteLine($"Ar Condicionado: {carro1.ArCond}");

            Console.WriteLine("\n\nInforme agora os dados do seu veículo.\n\n");

            Console.WriteLine("Informe o Modelo do carro:");
            carro2.Modelo = Console.ReadLine();

            Console.WriteLine("Informe a Cor carro:");
            cor2.Nome = Console.ReadLine();

            Console.WriteLine("Informe o quanto de Vermelho (R)");
            cor2.R = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o quanto de Verde (G)");
            cor2.G = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o quanto de Azul (B)");
            cor2.B = int.Parse(Console.ReadLine());

            carro2.Cor = cor2;

            Console.WriteLine("Informe a Placa do carro:");
            carro2.Placa = Console.ReadLine();

            Console.WriteLine("Informe o Valor do carro:");
            carro2.Valor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Ano do carro:");
            carro2.Ano = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Comprimento do carro:");
            carro2.Comprimento = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe se o carro tem Ar Condicionado: \n1 - Sim \n2 - Não");
            int arCond = int.Parse(Console.ReadLine());

            if (arCond == 1)
            {
                carro2.ArCond = true;
            }
            else
            {
                carro2.ArCond = false;
            }

            Console.WriteLine("\nOs dados do seu carro são:\n");

            Console.WriteLine($"Modelo: {carro2.Modelo}");
            Console.WriteLine($"Placa: {carro2.Placa}");
            Console.WriteLine($"Cor: {carro2.Cor.Nome}");
            Console.WriteLine($"Quantidade de Vermelho: {carro2.Cor.R}");
            Console.WriteLine($"Quantidade de Verde: {carro2.Cor.G}");
            Console.WriteLine($"Quantidade de Azul: {carro2.Cor.B}");
            Console.WriteLine($"Valor: {carro2.Valor}");
            Console.WriteLine($"Ano: {carro2.Ano}");
            Console.WriteLine($"Comprimento: {carro2.Comprimento} metros");
            Console.WriteLine($"Ar Condicionado: {carro2.ArCond}");

        }
    }
}
