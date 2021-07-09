using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula08.Exemplo01.Services
{
    public class EmailMessage : IMessage
    {
        //Classe implementa a interface
        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Enviando o e-mail: {mensagem}");
        }
    }
}
