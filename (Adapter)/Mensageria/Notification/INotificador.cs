//Create class EmailNotification

namespace Mensageria.classes
{
    public interface INotificador
    {
        void enviar(string mensagem, string destinatario);
    }
}