using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
