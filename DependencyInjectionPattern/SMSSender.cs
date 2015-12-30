
using System;
namespace DependencyInjectionPattern
{
    //Concrete class
    public class SMSSender : INotificationAction
    {
        public void DeliverNotification(string message)
        {
            Console.WriteLine(string.Concat("Mensaje vía SMS: ", message));
        }
    }
}
