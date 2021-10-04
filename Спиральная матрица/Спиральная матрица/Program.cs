using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Спиральная_матрица
{
    class Program
    {
        static void Main(string[] args)
        {

            int m = 5;
            int n = 5;

            //С помощью переменной s задаются числа внутри массива,
            //начиная с 25 в данном случае.
            int s = m * n;

            //Объявляем и инициализируем массив.
            int[,] array = new int[m, n];

            //Заполняем периметр массива по часовой стрелке.
            for (int y = 0; y < n; y++)
            {
                array[0, y] = s;
                s--;
            }
            for (int x = 1; x < m; x++)
            {
                array[x, n - 1] = s;
                s--;
            }
            for (int y = n - 2; y >= 0; y--)
            {
                array[m - 1, y] = s;
                s--;
            }
            for (int x = m - 2; x > 0; x--)
            {
                array[x, 0] = s;
                s--;
            }

            //Периметр заполнен. Продолжаем заполнять массив и задаём координаты ячейки, которую необходимо заполнить следующей.

            int c = 1;
            int d = 1;


            while (s > 1)
            {
                //Периметр мы заполнили числами, отличными от нулей.
                //Следующие циклы поочерёдно работают, заполняя ячейки.
                //Вложенный цикл останавливается, если следующая ячейка имеет 
                //значение, отличное от ноля. Ячейка, на которой остановился 
                //цикл, не заполняется. Из-за этого условие для выхода из внешнего цикла - (s>1).

                //Движемся вправо.
                while (array[c, d + 1] == 0)
                {
                    array[c, d] = s;
                    s--;
                    d++;
                }

                //Движемся вниз.
                while (array[c + 1, d] == 0)
                {
                    array[c, d] = s;
                    s--;
                    c++;
                }

                //Движемся влево.
                while (array[c, d - 1] == 0)
                {
                    array[c, d] = s;
                    s--;
                    d--;
                }

                //Движемся вверх.
                while (array[c - 1, d] == 0)
                {
                    array[c, d] = s;
                    s--;
                    c--;
                }
            }

            //При данном решении в центре всегда остаётся незаполненная ячейка.
            //Убираем её при помощи следующего цикла.
            for (int x = 0; x < m; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (array[x, y] == 0)
                    {
                        array[x, y] = s;
                    }
                }
            }

            //Выводим массив в консоль.
            for (int x = 0; x < m; x++)
            {
                for (int y = 0; y < n; y++)
                {
                    if (array[x, y] < 10)
                    {
                        //Два пробела, чтобы в консоли столбцы были ровные.
                        Console.Write(array[x, y] + ",  ");
                    }
                    else
                    {
                        Console.Write(array[x, y] + ", ");
                    }
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
