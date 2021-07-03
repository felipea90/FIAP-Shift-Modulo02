namespace Fiap.Aula05.Exercicio01.Models
{
    public class Eletronico : Produto
    {
        public bool Garantia { get; set; }

        public Eletronico(
            int id, 
            string nome) : base(id, nome)
        {

        }

        public decimal CalcularGarantiaEstendida()
        {
            return !Garantia ? 0 : Preco * 0.1m;
        }
        //Passar m ao final do valor para explicitar que é um decimal sem usar a conversão

        //Sobrescrever o método CalcularGarantiaEstendida()
        public decimal CalcularGarantiaEstendida(int anos)
        {
            return CalcularGarantiaEstendida() * anos;
            //return !Garantia ? 0 : Preco * 0.1m * anos;
        }
    }
}
