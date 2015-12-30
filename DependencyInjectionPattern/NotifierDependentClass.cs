using System;

namespace DependencyInjectionPattern
{
    //Dependent class
    public class NotifierDependentClass
    {
        // Handle to EventLog writer to write to the logs
        INotificationAction action = null;

        //property aproach
        public INotificationAction Action
        {
            set
            {
                this.action = value;
            }
        }

        public NotifierDependentClass()
        {
            //default constructor
        }

        //constructor aproach
        public NotifierDependentClass(INotificationAction action)
        {
            this.action = action;
        }


        // This function will be called when the app pool has problem
        public void Notify(string message)
        {
            if (action != null)
            {
                action.DeliverNotification(message);
            }
            else
            {
                Console.WriteLine("No se ha establecido la clase concreta");
            }
        }

        // This function will be called when the app pool has problem
        public void Notify(INotificationAction action,string message)
        {
            this.action = action;
            this.Notify(message);
        }
    }
}
