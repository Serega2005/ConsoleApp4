using System;

namespace Calc
{
    public delegate void Message(string message);
    public class Program
    {
        public static Message Info;
        public static Message Error;
        static void Main()
        {
            var calculator = new Calculator();

            //var result = calculator.Calc(12, 43, (num1, num2)=>num1+num2);
            var result = calculator.Calc(12, 43, Sum);
            Console.WriteLine($"sum = {result}");

            //result = calculator.Calc(32, 13, (num1, num2) => num1 - num2);
            result = calculator.Calc(12, 43, Sub);
            Console.WriteLine($"sub = {result}");

            //result = calculator.Calc(20, 5, (num1, num2)=> num1*num2);
            result = calculator.Calc(12, 43, Mul);
            Console.WriteLine($"mul = {result}");

            //result = calculator.Calc(200, 25, (num1, num2) => num1 / num2);
            result = calculator.Calc(12, 43, Div);
            Console.WriteLine($"div = {result}");

            //result = calculator.Calc(43, 23, (num1, num2) => num1 > num2 ? num1 : num2);
            result = calculator.Calc(12, 43, Max);
            Console.WriteLine($"max = {result}");

            //result = calculator.Calc(13, 23, (num1, num2) => num1 < num2 ? num1 : num2);
            result = calculator.Calc(12, 43, Min);
            Console.WriteLine($"min = {result}");

            //result = calculator.Calc(12, 10, (num1, num2) => (num1 + num2) / 2);
            result = calculator.Calc(12, 43, Ave);
            Console.WriteLine($"ave = {result}");
        }
        
        public static double Sum(double num1, double num2)
        {
            Info?.Invoke("Функция сложения выполнена");
            return num1 + num2;
        }

        public static double Sub(double num1, double num2)
        {
            Info?.Invoke("Функция вычитания выполнена");
            return num1 - num2;
        }

        public static double Mul(double num1, double num2)
        {
            Info?.Invoke("Функция умножения выполнена");
            return num1 * num2;
        }

        public static double Div(double num1, double num2)
        {
            if (num1 == 0 || num2 == 0)
            {
                Error?.Invoke("Делить на ноль нельзя");
                return 0;
            }
            else
            {
                Info?.Invoke("Функция деления выполнена");
                return num1 / num2;
            }
        }

        public static double Max(double num1, double num2)
        {
            if (!(num1 == num2) || num1 > num2)
            {
                Info?.Invoke("Функция вычисления максимального значения выполнена");
                return num1;
            }
            else if(!(num1 == num2) || num1 < num2)
            {
                Info?.Invoke("Функция вычисления максимального значения выполнена");
                return num2;
            }
            else
            {
                Error?.Invoke("Числа равны");
                return 0;
            }
        }

        public static double Min(double num1, double num2)
        {
            if (!(num1 == num2) || num1 < num2)
            {
                Info?.Invoke("Функция вычисления минимального значения выполнена");
                return num1;
            }
            else if (!(num1 == num2) || num1 > num2)
            {
                Info?.Invoke("Функция вычисления минимального значения выполнена");
                return num2;
            }
            else
            {
                Error?.Invoke("Числа равны");
                return 0;
            }
        }

        public static double Ave(double num1, double num2)
        {
            Info?.Invoke("Функция вычисления ср. значения выполнена");
            return (num1 + num2)/2;
        }

    }
}
