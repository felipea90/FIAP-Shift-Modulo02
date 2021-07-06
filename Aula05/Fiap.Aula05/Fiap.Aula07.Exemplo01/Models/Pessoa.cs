using System;

namespace Fiap.Aula07.Exemplo01.Models
{
    //Classe Abstrata -> não pode ser instanciada e pode definir métodos abstratos (sem implementação)
    public abstract class Pessoa
    {
        public string Nome { get; set; }
        public string Endereco { get; set; }

        //Métodos
        public abstract void CadastrarEndereco(string endereco);

        public void InformarNome()
        {
            Console.WriteLine("Informe o nome");
            Nome = Console.ReadLine();
        }
    }
}
