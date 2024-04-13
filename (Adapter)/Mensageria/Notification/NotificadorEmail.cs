//Create class EmailNotification
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mensageria.classes
{
    public class NotificadorEmail : INotificador
    {
        public void enviar(string mensagem, string destinatario)
        {
            Console.WriteLine("Email enviado com sucesso!");
            Console.WriteLine("mensagem: " + mensagem);
            Console.WriteLine("destinatario: " + destinatario);
        }
    }
}