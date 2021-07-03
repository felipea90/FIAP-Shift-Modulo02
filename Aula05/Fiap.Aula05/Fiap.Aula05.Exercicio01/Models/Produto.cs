namespace Fiap.Aula05.Exercicio01.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public Fornecedor Fornecedor { get; set; }

        public Produto(
            int id, 
            string nome)
        {
            Id = id;
            Nome = nome;
        }

        public decimal CalcularDesconto(decimal porcentagem)
        {
            return Preco - (Preco * (porcentagem/100));
        }
    }
}
