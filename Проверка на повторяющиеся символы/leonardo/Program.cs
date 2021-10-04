using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leonardo
{
    class Program
    {
        static void Main(string[] args)
        {
            int lon, count = 0;
            string word;
            {
                do
                {
                    Console.WriteLine("Введите слово");
                    word = Console.ReadLine();
                    lon = word.Length;
                } while (lon <= 6);
                foreach (char sobaka in word)
                {
                    Console.WriteLine(sobaka);
                }
                Console.WriteLine();
                for (int i = 0; i < lon; i++)
                {
                    for (int n = 0; n < lon-1; n++)
                    {
                        if (word[i] == word[n + 1])
                            count++;
                    }
                }
                Console.WriteLine("Повторяющихся символов: " + count);
                Console.WriteLine(lon);
                Console.ReadKey();
            }

        }
    }



}
// НУЖНО ВВЕСТИ СЛОВО НЕ МЕНЬШЕ 6 СИМВОЛОВ. ЕСЛИ МЕНЬШЕ, ТО ПОПРОСИТЬ ВВЕСТИ ЗАНОВО. ЕСЛИ БОЛЬШЕ, ТО ВЫВЕСТИ В СТРОКУ КОЛИЧЕСТВО ПОВТОРЯЮЩИХСЯ СИМВОЛОВ.

