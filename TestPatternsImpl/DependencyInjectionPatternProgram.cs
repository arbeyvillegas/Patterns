using DependencyInjectionPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatternsImpl
{
    class DependencyInjectionPatternProgram
    {
        static void Main(string[] args)
        {
            ConstructorInjection();
            MethodInjection();
            PropertyInjection();

            Console.ReadKey();
        }

        static void ConstructorInjection()
        {
            Console.WriteLine("Constructor injection");
            INotificationAction sender = new SMSSender();
            NotifierDependentClass notifier = new NotifierDependentClass(sender);
            notifier.Notify("constructor aproach DI");
        }

        static void PropertyInjection()
        {
            Console.WriteLine("Property injection");
            INotificationAction sender = new EventLogWriter();
            NotifierDependentClass notifier = new NotifierDependentClass();

            notifier.Action = sender;

            notifier.Notify("property aproach DI");
        }

        static void MethodInjection()
        {
            Console.WriteLine("Method injection");
            INotificationAction sender = new EmailSender();
            NotifierDependentClass notifier = new NotifierDependentClass();

            notifier.Notify(sender,"method aproach DI");
        }
    }
}
