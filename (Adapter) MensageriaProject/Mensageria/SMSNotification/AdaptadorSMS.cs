using Mensageria.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensageria.PushNotification
{
    internal class AdaptadorSMS : INotificador
    {
        private SMS sms = new SMS();
        void INotificador.enviar(string mensagem, string destinatario)
        {
           sms.enviarSMS(destinatario, mensagem);
        }
    }
}
