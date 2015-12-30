using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public static class Facade
    {

        public static string FunctionA()
        {
            ClassA claseA=new ClassA();
            StringBuilder builderCadena = new StringBuilder();

            builderCadena.AppendLine(claseA.FunctionA_1());
            builderCadena.AppendLine(claseA.FunctionA_2());
            builderCadena.AppendLine(claseA.FunctionA_3());

            return builderCadena.ToString();

        }
         
        public static string FunctionB()
        {
            ClassB claseB = new ClassB();
            StringBuilder builderCadena = new StringBuilder();

            builderCadena.AppendLine(claseB.FunctionB_1());
            builderCadena.AppendLine(claseB.FunctionB_2());
            builderCadena.AppendLine(claseB.FunctionB_3());

            return builderCadena.ToString();
        }

        public static string FunctionC()
        {
            ClassC claseC = new ClassC();
            StringBuilder builderCadena = new StringBuilder();

            builderCadena.AppendLine(claseC.FunctionC_1());
            builderCadena.AppendLine(claseC.FunctionC_2());
            builderCadena.AppendLine(claseC.FunctionC_3());

            return builderCadena.ToString();
        }
    }
}