namespace Fiap.Aula05.Exercicio01.Models
{
    public class Livro : Produto
    {
        public string Autor { get; set; }
        public int NumeroPaginas { get; set; }
        public int AnoPublicacao { get; set; }

        public Livro(
            int id, 
            string nome, 
            string autor, 
            int numeroPaginas, 
            int anoPublicacao) : base(id, nome)
        {
            Autor = autor;
            NumeroPaginas = numeroPaginas;
            AnoPublicacao = anoPublicacao;
        }

        //Soobrescrever o método definido na classe "pai" (override)
        public override decimal CalcularDesconto()
        {
            return CalcularDesconto(35);
        }

        //Sobrescrever o método desconto com Cupom, adicionando cupom FIAPBOOK com 30%
        public override decimal CalcularDesconto(string cupom)
        {
            return cupom.ToUpper() == "FIAPBOOK" ? CalcularDesconto(30) 
                   : cupom.ToUpper() == "FIAP10" ? CalcularDesconto(10) : Preco;
        }
    }
}
