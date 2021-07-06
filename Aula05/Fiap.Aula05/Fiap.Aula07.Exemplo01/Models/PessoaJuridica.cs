namespace Fiap.Aula07.Exemplo01.Models
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }

        public override void CadastrarEndereco(string endereco)
        {
            System.Console.WriteLine("Cadastrar Endereço PJ");
            Endereco = endereco;
        }
    }
}
