using System;

namespace DependencyInjectionPattern
{
    //Concrete class
    public class EventLogWriter : INotificationAction
    {
        public void DeliverNotification(string message)
        {
            Console.WriteLine(string.Concat("Mensaje vía event log writer: ",message));
        }
    }
}
