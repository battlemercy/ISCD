using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Двумерный_массив
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int a = 0, j = 0; // а - доп. переменная для замены; j - цикл и номер столбца.
            Console.WriteLine("Введите количество элементов в строке");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество элементов в столбце");
            int m = Convert.ToInt32(Console.ReadLine());

            int[,] mass = new int[n, m]; // двумерный массив

            Random ran = new Random(); // рандом

            for (int i = 0; i < n; ++i)
            {
                for (j = 0; j < m; ++j)
                {
                    mass[i, j] = ran.Next(1, 9); // рандомные значения
                }
            }

            Console.WriteLine("Матрица: ");

            for (int i = 0; i < n; ++i)
            {
                for  (j = 0; j < m; ++j)
                {
                    Console.Write(mass[i, j] + " "); // вывод обычной матрицы
                }
                Console.WriteLine();
            }

            Console.WriteLine("Матрица с изменёнными диагоналями: ");

            for (int i = 0; i < n; ++i)
            {
                a = mass[i, i];
                mass[i, i] = mass[i, j - i - 1]; // меняем
                mass[i, j - i - 1] = a;
            }

            for (int i = 0; i < n; ++i)
            {
                for (j = 0; j < m; ++j)
                {
                    Console.Write(mass[i, j] + " "); // выводим матрицу
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (j = (m - 1) / 2 + 1; j < m; ++j)
            {
                for (int i = (n - 1) / 2 + 1; i < n; ++i)
                {
                    Console.Write(mass[i,j] + "  ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();*/

            int zamena = 0;
            Console.WriteLine("Введите размер строки/столба матрицы: ");
            int size = Convert.ToInt32(Console.ReadLine()); // размер матрицы
            int[,] matrix = new int[size, size]; // создание матрицы
            Random r = new Random(); // рандомные значения
            Console.WriteLine("Матрица: ");
            for (int i = 0; i < size; ++i)
            {
                Console.WriteLine();
                for (int j = 0; j < size; ++j)
                {
                    matrix[i, j] = r.Next(0, 9);       // значения в матрице
                    Console.Write(matrix[i,j] + " ");
                }
            }
            Console.WriteLine(); // отступы
            Console.WriteLine();

            Console.WriteLine("Изменённая матрица: ");
            Console.WriteLine(" ");
            for (int i = 0; i < size; ++i)
            {
                zamena = matrix[i, i];
                matrix[i, i] = matrix[i, size - i - 1]; // меняем
                matrix[i, size - i - 1] = zamena;
            }

            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    Console.Write(matrix[i, j] + " "); // выводим обновлённую матрицу
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int a = 0, b = 1, c = 2;
            for (int i = 0; i < size; ++i)
            {
                for (int j = a; j < size - a; ++j)
                {
                    Console.Write(matrix[a, j] + "  ");
                }
                for (int j = b; j < size - a; ++j)
                {
                    Console.Write(matrix[j, size - b] + "  ");
                }
                for (int j = size - c; j >= a; --j)
                {
                    Console.Write(matrix[size - b, j] + "  ");
                }
                for (int j = size - c; j > a; --j)
                {
                    Console.Write(matrix[j, a] + "  ");
                }
                ++c;
                ++b;
                ++a;
                /*for (int j = a; j < size - a; ++j)
                {
                    Console.Write(matrix[a, j] + "  ");
                }
                for (int j = b; j < size - a; ++j)
                {
                    Console.Write(matrix[j, size - b] + "  ");
                }
                for (int j = size - c; j >= a; --j)
                {
                    Console.Write(matrix[size - b, j] + "  ");
                }
                for (int j = size - c; j > a; --j)
                {
                    Console.Write(matrix[j, a] + "  ");
                }*/
            }
            Console.ReadKey();
        }
    }
}
// вывести массив по спирали.