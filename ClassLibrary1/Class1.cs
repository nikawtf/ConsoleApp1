using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public int plus(int a, int b)
        {
            return a + b;
        }
        public int minus(int a, int b)
        {
            return a - b;
        }
        public int multiply(int a, int b)
        {
            return a * b;
        }
        public int divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("не делится на нуль!!!!!хзапзхпахзахахаах");
            }
            return a / b;
        }
    }
}
