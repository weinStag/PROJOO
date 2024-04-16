using Mensageria;
using Mensageria.classes;
using Mensageria.PushNotification;

public static class Program
{
    //CÓDIGO DESENVOLVIDO POR:
    //PAULO CHIARADIA - 156658
    //VINICIUS DIAS - 156736

    public static void Main(string[] args)
    {
        INotificador notificadorPush = new AdaptadorPush();
        INotificador notificadorSMS = new AdaptadorSMS();
        INotificador notificadorEmail = new NotificadorEmail();

        notificadorPush.enviar("Texto Push", "12345");
        Console.WriteLine("");
        notificadorSMS.enviar("Texto SMS", "(12)99543-2210");
        Console.WriteLine("");
        notificadorEmail.enviar("Texto Email", "Email@Mail.com");
    }
}