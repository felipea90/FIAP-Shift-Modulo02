using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula02.Exercicio01.Models
{
    public class Lancha
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Potencia { get; set; }
        public double Peso { get; set; }
        public string Cor { get; set; }
        public DateTime AnoFabricacao { get; set; }
        public decimal Valor { get; set; }
    }
}
