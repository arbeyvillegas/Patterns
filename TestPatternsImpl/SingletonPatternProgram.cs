using SingletonPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatternsImpl
{
    class SingletonPatternProgram
    {
        static void Main(string[] args)
        {
            SingletonPattern.Singleton singleton =  Singleton.Instance;//new SingletonPattern.Singleton();
            int hashCode=singleton.HashCode();
            Console.WriteLine(hashCode);

            SingletonPattern.Singleton singleton2 = Singleton.Instance;//new SingletonPattern.Singleton();
            hashCode = singleton2.HashCode();
            Console.WriteLine(hashCode);

            Console.ReadKey();
        }
    }
}
