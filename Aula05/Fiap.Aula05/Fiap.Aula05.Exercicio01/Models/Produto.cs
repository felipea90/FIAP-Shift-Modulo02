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

        //Sobrecarga de método: mesmo nome, mas sem ou com parâmetros diferentes
        public virtual decimal CalcularDesconto()
        {
            //Exemplo desconto padrão de 5%
            //return Preco - (Preco * 0.05m);
            return CalcularDesconto(5);
        }

        public virtual decimal CalcularDesconto(string cupom)
        {
            //Exemplo: FIAP10 dá 10% de desconto
            return cupom == "FIAP10" ? CalcularDesconto(10) : Preco;
        }
    }
}
