using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TooMuch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Введите имя");
            Console.WriteLine($"Привет, {Console.ReadLine()}!");

            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Нельзя делить на 0");
            }
            else
            {
                Console.WriteLine("Результат: " + a / b);
            }

            Console.WriteLine("Задание 3");

            string s;
            int sled;
            Console.WriteLine("Введите букву: ");
            s = Console.ReadLine();
            foreach (char c in s)
            {
                sled = ((int)c + 1);
                Console.WriteLine("Следующая буква: " + (char)sled);
            }
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите коэффициент a: ");
            double a1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент c: ");
            double c1 = double.Parse(Console.ReadLine());
            if ((b1 * b1 - 4 * a1 * c1) > 0)
            {
                double rez1 = (-b1 + Math.Sqrt(b1 * b1 - 4 * a1 * c1)) / 2 * a1;
                double rez2 = (-b1 - Math.Sqrt(b1 * b1 - 4 * a1 * c1)) / 2 * a1;
                Console.WriteLine($"Уравнение имеет 2 корня: {rez1} и {rez2}");
            }
            if ((b1 * b1 - 4 * a1 * c1) == 0)
            {
                double rez1 = (-b1 + Math.Sqrt(b1 * b1 - 4 * a1 * c1)) / 2 * a1;
                Console.WriteLine($"Уравнение имеет 1 корень {rez1}");
            }
            else
            {
                Console.WriteLine("Нет корней");
            }
        }

    }
}
