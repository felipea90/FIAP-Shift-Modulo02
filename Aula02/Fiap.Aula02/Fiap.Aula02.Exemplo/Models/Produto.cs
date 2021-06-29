namespace Fiap.Aula02.Exemplo.Models
{
    public class Produto
    {
        //Atributos Privados
        private int _id;

        //Getters e Setters (Propriedades)
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nome { get; set; } //String padrão é NULL

        public decimal Valor { get; set; } //Número padrão é 0

        public Fabricante Fabricante { get; set; } //Classes padrão é NULL

        //Variáveis não são inicializadas com o valor padrão

        //Métodos
        //Calcular o valor do produto com desconto e retornar na tela
        public decimal CalcularDesconto(decimal desconto)
        {
            return Valor - (Valor * desconto / 100);
        }

        //Cadastrar um produto, não recebe e não retorna informação (Void)
        public void Cadastrar()
        {
            System.Console.WriteLine("Produto em processo de cadastro...");
        }
    }
}
