using Mensageria.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensageria.PushNotification
{
    internal class AdaptadorPush : INotificador
    {
        private Push push = new Push();
        void INotificador.enviar(string mensagem, string destinatario)
        {
            push.enviarPush(destinatario, mensagem);
        }
    }
}
