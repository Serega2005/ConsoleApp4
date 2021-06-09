using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main()
        {
            var operation = new Operation();

            var result = operation.Calc(5, 4, Add);
            Console.WriteLine($"sum = {result}");

            result = operation.Calc(5, 4, Max);
            Console.WriteLine($"max = {result}");

            result = operation.Calc(5, 4, (num1, num2)=>num1+num2);
        }

        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Max(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }
    }
}
