using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mensageria.PushNotification
{
    internal class Push
    {
        public void enviarPush(string idDispositivo, string mensagem)
        {
            Console.WriteLine("Push enviado com sucesso!");
            Console.WriteLine("mensagem: " + mensagem);
            Console.WriteLine("idDispositivo: " + idDispositivo);
        }
    }
}
