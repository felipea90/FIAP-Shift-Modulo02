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

    }
}
