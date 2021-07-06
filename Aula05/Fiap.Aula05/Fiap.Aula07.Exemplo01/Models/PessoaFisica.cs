namespace Fiap.Aula07.Exemplo01.Models
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }

        public Genero Genero { get; set; }

        public override void CadastrarEndereco(string endereco)
        {
            System.Console.WriteLine("Cadastrar Endereço PF");
            Endereco = endereco;
        }

    }
}
