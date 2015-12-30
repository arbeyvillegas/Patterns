using System;

namespace DependencyInjectionPattern
{
    //Concrete class
    public class EmailSender:INotificationAction
    {
        public void DeliverNotification(string message)
        {
            Console.WriteLine(string.Concat("Mensaje vía email: ", message));
        }
    }
}
