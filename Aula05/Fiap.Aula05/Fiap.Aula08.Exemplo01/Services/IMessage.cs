using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Aula08.Exemplo01.Services
{
    //Define o contrato, os métodos que a classe deve implementar
    public interface IMessage
    {
        void EnviarMensagem(string mensagem);
    }
}
