using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace c1_method
{
    public class class1
    {
        public void someMethod()
        {
            System.Console.WriteLine("Non static method");
        }

        public static void staticMethod()
        {
            System.Console.WriteLine("Static method");
        }
    }

    public static class class2
    {
        public static void someMethod2()
        {
            
        }
    }
}