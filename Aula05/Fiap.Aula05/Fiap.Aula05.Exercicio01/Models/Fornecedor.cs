namespace Fiap.Aula05.Exercicio01.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        public Fornecedor(
            int id, 
            string nome, 
            string telefone)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
        }
    }
}
