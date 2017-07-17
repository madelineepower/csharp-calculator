using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        public int Multiply(int a, int b)
        {
            int product = a * b;
            return product;
        }
    }
}
