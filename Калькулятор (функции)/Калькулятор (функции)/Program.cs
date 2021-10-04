using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Калькулятор__функции_
{
    class Program
    {
        public static double Division(double first, double second)
        {
            double result = first / second;
            return result;
        }
        public static double Multiplication(double first, double second)
        {
            double result = first * second;
            return result;
        }
        public static double Addition(double first, double second)
        {
            double result = first + second;
            return result;
        }
        public static double Subtraction(double first, double second)
        {
            double result = first - second;
            return result;
        }

        static void Main(string[] args)
        {m1:
            try
            {
                Console.WriteLine("Введите первое число: ");
                double first = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите второе число: ");
                double second = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Введите действие между этими числами: ");
                string action = Convert.ToString(Console.ReadLine());
                if (action == "/")
                {
                    Console.WriteLine("Ответ: ");
                    Division(first, second);
                    Console.WriteLine(Division(first, second));
                }
                else if (action == "*")
                {
                    Console.WriteLine("Ответ: ");
                    Multiplication(first, second);
                    Console.WriteLine(Multiplication(first, second));
                }
                else if (action == "+")
                {
                    Console.WriteLine("Ответ: ");
                    Addition(first, second);
                    Console.WriteLine(Addition(first, second));
                }
                else if (action == "-")
                {
                    Console.WriteLine("Ответ: ");
                    Subtraction(first, second);
                    Console.WriteLine(Subtraction(first, second));
                }
                else
                {
                    Console.WriteLine("Произошла ошибка.");
                }
            }
            catch
            {
                Console.WriteLine("Произошла ошибка.");
            }
            Console.WriteLine("Nazhmite na Enter shtob nachat zanovo, inache napishite lubuy bukvu");
            string enter = Convert.ToString(Console.ReadLine());
            if (enter == "")
            {
                goto m1;
            }
            else
            {
                Console.WriteLine("GoodBye");
            }
            Console.ReadKey();
        }
    }
}
