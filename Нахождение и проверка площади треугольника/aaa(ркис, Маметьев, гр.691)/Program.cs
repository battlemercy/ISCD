using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaa_ркис__Маметьев__гр._691_
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, y1, y2, y3;
            Console.WriteLine("Введите значения по X:");

            x1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            x3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значения по Y:");
            
            y1 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            y3 = Convert.ToDouble(Console.ReadLine());
            
            double Sabc = 0;
            double ab, bc, ac, p;
            {
                ab = Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2));
                bc = Math.Sqrt(Math.Pow(y3 - y2, 2) + Math.Pow(x3 - x2, 2));
                ac = Math.Sqrt(Math.Pow(y3 - y1, 2) + Math.Pow(x3 - x1, 2));

                p = (ab + bc + ac) / 2;
                Sabc = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
            }

            Console.WriteLine("Площадь треугольника равна:" + Sabc); // дальше не понимаю

            double Dx, Dy;
            Console.WriteLine("Введите значение точки D по Х:");
            
                Dx = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Введите значение точки D по Y:");
            
                Dy = Convert.ToDouble(Console.ReadLine());
            
            double Sacd = 0, ad, dc;
            {
                ac = Math.Sqrt(Math.Pow(y3 - y1, 2) + Math.Pow(x3 - x1, 2));
                ad = Math.Sqrt(Math.Pow(Dy - y1, 2) + Math.Pow(Dx - x1, 2));
                dc = Math.Sqrt(Math.Pow(y3 - Dy, 2) + Math.Pow(x3 - Dx, 2));
                p = (ac + ad + dc) / 2;
                Sacd = Math.Sqrt(p * (p - ac) * (p - ad) * (p - dc));
            }

            double Sabd = 0, bd;
            {
                ab = Math.Sqrt(Math.Pow(y2 - y1, 2) + Math.Pow(x2 - x1, 2));
                ad = Math.Sqrt(Math.Pow(Dy - y1, 2) + Math.Pow(Dx - x1, 2));
                bd = Math.Sqrt(Math.Pow(y2 - Dy, 2) + Math.Pow(x2 - Dx, 2));
                p = (ab + ad + bd) / 2;
                Sabd = Math.Sqrt(p * (p - ab) * (p - ad) * (p - bd));
            }

            double Sbdc = 0, cd;
            {
                bd = Math.Sqrt(Math.Pow(y2 - Dy, 2) + Math.Pow(x2 - Dx, 2));
                bc = Math.Sqrt(Math.Pow(y3 - y2, 2) + Math.Pow(x3 - x2, 2));
                cd = Math.Sqrt(Math.Pow(x3 - Dx, 2) + Math.Pow(y3 - Dy, 2));
                p = (bd + bc + cd) / 2;
                Sbdc = Math.Sqrt(p * (p - bd) * (p - bc) * (p - cd));
            }

            if (Sabc == Sacd + Sabd + Sbdc)
            {
                Console.WriteLine("Принадлежит треугольнику");
            }
            else
            {
                Console.WriteLine("Не принадлежит треугольнику");
            }
            Console.ReadKey();
        }
    }
}
