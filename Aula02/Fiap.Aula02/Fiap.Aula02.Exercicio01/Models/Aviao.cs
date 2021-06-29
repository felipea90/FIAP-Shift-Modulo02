using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula02.Exercicio01.Models
{
    public class Aviao
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double Comprimento { get; set; }
        public Cor Cor { get; set; }
        public string Prefixo { get; set; }
        public float AlturaCarreta { get; set; }
        public double HorasVoo { get; set; }

    }
}
