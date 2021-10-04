using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _123
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            int lon;
            int del;
            string word1;
            string word2;
                Console.WriteLine("Введите слово");
                word = Console.ReadLine();
                lon = word.Length;
                Console.WriteLine();
                foreach (char sobaka in word)
                {
                    Console.WriteLine(sobaka);
                }
                Console.WriteLine();
                if (lon > 6)
                {
                    Console.WriteLine("Какой символ твоего слова удалить?");
                    del = Convert.ToInt32(Console.ReadLine());
                    word = word.Remove(del, 1);
                    Console.WriteLine();
                    foreach (char sobaka1 in word)
                    {
                        Console.WriteLine(sobaka1);
                    }
                    Console.WriteLine();
                }
                else
                {
                    if (lon < 6)
                    {
                        Console.WriteLine("В какое место в твоем слове вставить букву?");
                        del = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Какой символ добавить в твоё слово?");
                        string symbol = Console.ReadLine();
                        word = word.Insert(del, symbol);
                        Console.WriteLine();
                        foreach (char sobaka1 in word)
                        {
                            Console.WriteLine(sobaka1);
                        }
                        Console.WriteLine();
                    }
                    else
                    {
                        word1 = word;
                        Console.WriteLine("Введите слово");
                        word2 = Console.ReadLine();
                        lon = word2.Length;
                        Console.WriteLine();
                        foreach (char sobaka in word1)
                        {
                            Console.WriteLine(sobaka);
                        }
                        Console.WriteLine();
                        foreach (char sobaka in word2)
                        {
                            Console.WriteLine(sobaka);
                        }
                        Console.WriteLine();

                    }
                } Console.ReadKey();
        }   
    }
}
// ПОЛЬЗОВАТЕЛЬ ДОЛЖЕН ВВЕСТИ СЛОВО. ЭТО СЛОВО НУЖНО ВЫВЕСТИ ПОСТРОЧНО. ПОСЛЕ ЭТОГО НУЖНО СДЕЛАТЬ: ЕСЛИ СЛОВО >6 СИМВОЛОВ, ТО УДАЛЯЕМ ЛЮБОЙ СИМВОЛ. ЕСЛИ МЕНЬШЕ <6, ТО ДОБАВИТЬ ЛЮБУЮ БУКВУ. ЕСЛИ = 6, 
// ТО ПОЛЬЗОВАТЕЛЬ ДОЛЖЕН ВВЕСТИ ЕЩЁ СЛОВО, И ВЫВОДИТ ДВА СЛОВА.