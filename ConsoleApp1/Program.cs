using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 calculator = new Class1();
            Console.WriteLine("Введите первое число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("a + b = {0}", calculator.plus(a, b));
            Console.WriteLine("a - b = {0}", calculator.minus(a, b));
            Console.WriteLine("a * b = {0}", calculator.multiply(a, b));
            Console.WriteLine("a / b = {0}", calculator.divide(a, b));
        }
    }
}
