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
            //Mensagem não pode ter menos do que 5 caracteres
            if (mensagem.Length < 5)
            {
                //Lança uma exceção, "retorna" o objeto da exceção
                throw new Exception("Texto deve ser maior do que 5 caracteres");
            }
            Console.WriteLine($"Enviando o e-mail: {mensagem}");
        }
    }
}
