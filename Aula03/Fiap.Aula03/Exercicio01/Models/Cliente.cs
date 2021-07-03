namespace Exercicio01.Models
{
    public class Cliente
    {
        public Cliente(
            string nome,
            string cpf,
            string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }
        
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
    }
}
