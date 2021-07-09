using Fiap.Aula08.Exemplo01.Services;
using System;

namespace Fiap.Aula08.Exemplo01
{
    class Exemplo01
    {
        static void Main(string[] args)
        {
            //Ler a mensagem
            Console.WriteLine("Digite a mensagem");
            var msg = Console.ReadLine();

            //Interface -> Diminuir o acoplamento (dependência) entre os projetos
            //Instanciar um EmailMessage
            IMessage message = new EmailMessage();

            //Chamar o método que envia a mensagem
            message.EnviarMensagem(msg);

        }
    }
}
