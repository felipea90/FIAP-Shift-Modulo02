using System;

namespace Fiap.Aula01.Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler uma string
            //cw -> tab tab
            Console.WriteLine("Informe o seu nome:");
            string nome = Console.ReadLine();

            //Ler um número
            Console.WriteLine("Informe a sua idade:");
            int numero = int.Parse(Console.ReadLine());

            //Exibir um dado
            Console.WriteLine($" Olá {nome} você têm {numero} anos.");
            
        }
    }
}
