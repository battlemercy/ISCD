using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice1_ркис__Маметьев__гр._691_
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, D, x1, x2;

            Console.WriteLine("Введите число a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите число c: ");
            c = Convert.ToDouble(Console.ReadLine());

            // a*x*x + b * x + c

            D = b * b - 4 * a * c;
            if (D < 0) { Console.WriteLine("Нет корней => нет решений"); }
            else if (D == 0) { Console.WriteLine("Присутствует один корень: "); Console.WriteLine(x1 = -b / (2 * a)); }
            else { Console.WriteLine("Присутствуют два корня: "); Console.WriteLine(x1 = (-b + Math.Sqrt(D)) / (2 * a)); Console.WriteLine(x2 = (-b - Math.Sqrt(D)) / (2 * a)); }

            Console.ReadKey();

            
        }
    }
}
