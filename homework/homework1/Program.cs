using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8; // без этой команды, консоль показывает вопросительные знаки вместо кириллицы. Update: без причины вводимые данные с клавиатуры на русском языке превращаются в вопросительные знаки.
            string code = "";
            do
            {
                Console.WriteLine("Введите свою фамилию");
                string second_name = Console.ReadLine();
                Console.WriteLine("Введите своё имя");
                string first_name = Console.ReadLine();
                Console.WriteLine("Введите своё отчество");
                string patronymic = Console.ReadLine();

                int age;

                Console.WriteLine("Введите свой возраст (число полных лет!)");
                age = Convert.ToInt32(Console.ReadLine());



                string date_of_birth;
                Console.WriteLine("Введите свою дату рождения (например 01.01.2001)");
                date_of_birth = Console.ReadLine();


                int seconds = age * 31536000; // динамический расчёт не умею делать, но научусь! =)
                int minutes = age * 525600;
                int hours = age * 8760;
                int days = age * 365;

                Console.WriteLine($"Вы: {second_name} {first_name} {patronymic}."); // $ - знак интерполяции, которая позволяет вывести в консоль значения сразу нескольких переменных.
                Console.WriteLine($"Вы прожили на данный момент {seconds} секунд, {minutes} минут, {hours} часов, {days} дней!");
                Console.WriteLine("Чтобы остановиться, пропишите HESOYAM.");
                code = Console.ReadLine();
                Console.ReadKey();
            }
            while (code != "HESOYAM");
        }
    }
}
