using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensageria.PushNotification
{
    internal class SMS
    {
        public void enviarSMS(string numero, string mensagem)
        {
            Console.WriteLine("SMS enviado com sucesso!");
            Console.WriteLine("Mensagem: " + mensagem);
            Console.WriteLine("Numero: " + numero);
        }
    }
}
