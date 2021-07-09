using Fiap.Aula08.Exemplo01.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula08.Exemplo01.Services
{
    public class SmsMessage : IMessage
    {
        public void EnviarMensagem(string mensagem)
        {
            //Validar se a mensagem tem menos de 10 caracteres e lançar Exception
            
            if (mensagem.Length < 10)
            {
                throw new InvalidMessageException("Mensagem com menos de 10 caracteres");
            }
            else
            {
                Console.WriteLine($"Enviando o SMS: {mensagem}");
            }
            
        }
    }
}
