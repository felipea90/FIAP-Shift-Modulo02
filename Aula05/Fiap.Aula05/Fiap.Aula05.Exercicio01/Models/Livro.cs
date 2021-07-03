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
    }
}
