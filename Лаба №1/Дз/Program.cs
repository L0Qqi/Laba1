using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

namespace dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1. Число e");
            double chislo = (Math.E);
            Console.WriteLine(Math.Round(chislo, 1));

            Console.WriteLine("Задание 2. Числа 50, 10");
            Console.WriteLine("50");
            Console.WriteLine("10");

            Console.WriteLine("Задание 3. 4 числа");
            int ch1 = int.Parse(Console.ReadLine());
            int ch2 = int.Parse(Console.ReadLine());
            int ch3 = int.Parse(Console.ReadLine());
            int ch4 = int.Parse(Console.ReadLine());
            Console.WriteLine(ch1);
            Console.WriteLine(ch2);
            Console.WriteLine(ch3);
            Console.WriteLine(ch4);

            Console.WriteLine("Задание 4. Число больше на 10");
            Console.WriteLine("Введите число: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a + 10);

            Console.WriteLine("Задание 5. Периметр квадрата");
            Console.WriteLine("Введите число(сторону квадрата): ");
            int storona = int.Parse(Console.ReadLine());
            Console.WriteLine(storona * 4);

            Console.WriteLine("Задание 6. Длина и площадь окружности");
            Console.WriteLine("Введите радиус окружности: ");
            int radius = int.Parse(Console.ReadLine());
            Console.WriteLine("Длина окружности: " + 2 * Math.PI * radius + " | Площадь окружности: " + Math.PI * Math.Pow(radius, 2));

            Console.WriteLine("Задание 7. Косинус");
            Console.WriteLine("Введите угол: ");
            double cosinus = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Cos(cosinus));

            Console.WriteLine("Задание 8. Периметр трапеции");

            Console.WriteLine("Введите длину первого основания: ");
            int osn1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину второго основания: ");
            int osn2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину высоты: ");
            int visota = int.Parse(Console.ReadLine());
            double storoni = Math.Sqrt(Math.Pow(((Math.Abs(osn1 - osn2)) / 2), 2) + Math.Pow(visota, 2));
            Console.WriteLine(2 * storoni + osn1 + osn2);

            Console.WriteLine("Задание 9. Магазин");
            int konfeti = 850;
            int pechenie = 500;
            int yabloki = 150;
            Console.WriteLine("Сколько кг конфет купили?");
            float kgkonf = float.Parse(Console.ReadLine());
            Console.WriteLine("Сколько кг печенья купили?");
            float kgpech = float.Parse(Console.ReadLine());
            Console.WriteLine("Сколько кг яблок купили?");
            float kgyablok = float.Parse(Console.ReadLine());
            Console.WriteLine($"Стоимость покупки: {kgkonf * konfeti + kgpech * pechenie + kgyablok * yabloki}");

            Console.WriteLine("Задание 10. Три строки");
            Console.WriteLine("Мир " + "Труд " + "Май");
            Console.WriteLine("Мир");
            Console.WriteLine("      Труд");
            Console.WriteLine("             Май");

            Console.WriteLine("Задание 11. 2 числа");
            Console.WriteLine("Введите 2 числа: ");
            string chislo1 = Console.ReadLine();
            string chislo2 = Console.ReadLine();
            if (double.TryParse(chislo1.Replace('.', ','), out double res1))
            {
                if (double.TryParse(chislo2.Replace('.', ','), out double res2))
                {
                    Console.WriteLine($"{chislo2} {chislo1}");
                }
            }
            else
            {
                Console.WriteLine("Проверьте правильность введённых чисел");
            }

            Console.WriteLine("Задание 12. Площадь или периметр");
            Console.WriteLine("Введите фигуру: ");
            string figura = Console.ReadLine().ToLower();
            switch (figura)
            {
                case "треугольник":
                    Console.WriteLine("Что необходимо найти?");
                    string deystv = Console.ReadLine().ToLower();

                    switch (deystv)
                    {
                        case "площадь":
                            Console.WriteLine("Введите длину и высоту");
                            int treug1 = int.Parse(Console.ReadLine());
                            int visota2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите диагонали четырёхугольника: ");
                            int ch11 = int.Parse(Console.ReadLine());
                            int ch21 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите угол между диагоналями: ");
                            int ugol = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите радиус окружности: ");
                            int radius1 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Площадь треугольника: {0.5 * treug1 * visota2}");
                            Console.WriteLine($"Площадь четырёхугольника: {0.5 * ch11 * ch21 * Math.Sin(ugol)}");
                            Console.WriteLine($"Площадь круга: {2 * Math.PI * radius1 * radius1}");

                            break;
                        case "периметр":
                            Console.WriteLine("Введите длины каждой из сторон треугольника");
                            int treug11 = int.Parse(Console.ReadLine());
                            int treug2 = int.Parse(Console.ReadLine());
                            int treug3 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите длины сторон четырёхугольника: ");
                            int ch111 = int.Parse(Console.ReadLine());
                            int ch211 = int.Parse(Console.ReadLine());
                            int ch31 = int.Parse(Console.ReadLine());
                            int ch41 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите радиус окружности: ");
                            int radius11 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Периметр треугольника: {treug11 + treug2 + treug3}");
                            Console.WriteLine($"Периметр четырёхугольника: {ch111 + ch211 + ch31 + ch41}");
                            Console.WriteLine($"Периметр круга: {2 * Math.PI * radius11}");
                            break;
                    }
                    break;
                case "четырёхугольник":
                    Console.WriteLine("Что необходимо найти?");
                    string deystv1 = Console.ReadLine().ToLower();
                    switch (deystv1)
                    {
                        case "площадь":
                            Console.WriteLine("Введите длину и высоту");
                            int treug1 = int.Parse(Console.ReadLine());
                            int visota2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите диагонали четырёхугольника: ");
                            int ch11 = int.Parse(Console.ReadLine());
                            int ch21 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите угол между диагоналями: ");
                            int ugol = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите радиус окружности: ");
                            int radius1 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Площадь треугольника: {0.5 * treug1 * visota2}");
                            Console.WriteLine($"Площадь четырёхугольника: {0.5 * ch11 * ch21 * Math.Sin(ugol)}");
                            Console.WriteLine($"Площадь круга: {2 * Math.PI * radius1 * radius1}");
                            break;
                        case "периметр":
                            Console.WriteLine("Введите длины каждой из сторон треугольника");
                            int treug11 = int.Parse(Console.ReadLine());
                            int treug2 = int.Parse(Console.ReadLine());
                            int treug3 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите длины сторон четырёхугольника: ");
                            int ch111 = int.Parse(Console.ReadLine());
                            int ch211 = int.Parse(Console.ReadLine());
                            int ch31 = int.Parse(Console.ReadLine());
                            int ch41 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите радиус окружности: ");
                            int radius11 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Периметр треугольника: {treug11 + treug2 + treug3}");
                            Console.WriteLine($"Периметр четырёхугольника: {ch111 + ch211 + ch3 + ch4}");
                            Console.WriteLine($"Периметр круга: {2 * Math.PI * radius11}");
                            break;
                    }
                    break;
                case "круг":
                    Console.WriteLine("Что необходимо найти?");
                    string deystv3 = Console.ReadLine().ToLower();
                    switch (deystv3)
                    {
                        case "площадь":
                            Console.WriteLine("Введите длину и высоту");
                            int treug1 = int.Parse(Console.ReadLine());
                            int visota2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите диагонали четырёхугольника: ");
                            int ch11 = int.Parse(Console.ReadLine());
                            int ch21 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите угол между диагоналями: ");
                            int ugol = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите радиус окружности: ");
                            int radius1 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Площадь треугольника: {0.5 * treug1 * visota2}");
                            Console.WriteLine($"Площадь четырёхугольника: {0.5 * ch11 * ch21 * Math.Sin(ugol)}");
                            Console.WriteLine($"Площадь круга: {2 * Math.PI * radius1 * radius1}");
                            break;
                        case "периметр":
                            Console.WriteLine("Введите длины каждой из сторон треугольника");
                            int treug12 = int.Parse(Console.ReadLine());
                            int treug2 = int.Parse(Console.ReadLine());
                            int treug3 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите длины сторон четырёхугольника: ");
                            int ch113 = int.Parse(Console.ReadLine());
                            int ch213 = int.Parse(Console.ReadLine());
                            int ch31 = int.Parse(Console.ReadLine());
                            int ch41 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Введите радиус окружности: ");
                            int radius13 = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Периметр треугольника: {treug12 + treug2 + treug3}");
                            Console.WriteLine($"Периметр четырёхугольника: {ch113 + ch213 + ch3 + ch4}");
                            Console.WriteLine($"Периметр круга: {2 * Math.PI * radius13}");
                            break;
                    }
                    break;
            }
            Console.WriteLine("Задание 13. Ввод числа");
            int chislo3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Вы ввели число " + chislo3);

            Console.WriteLine("Задание 14. Вывод числа");
            Console.WriteLine("2 кг");
            Console.WriteLine("13 17");

            Console.WriteLine("Задание 15. 4 случайных числа");
            Random rnd1 = new Random();
            Console.WriteLine(rnd1.Next());
            Console.WriteLine(rnd1.Next());
            Console.WriteLine(rnd1.Next());
            Console.WriteLine(rnd1.Next());

            Console.WriteLine("Задание 16. Корни квадратного уравнения");
            double x1;
            double x2;
            Console.WriteLine("Введите коэффициент a");
            double ak = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент b");
            double bk = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите коэффициент c");
            double ck = double.Parse(Console.ReadLine());
            double diskr = Math.Sqrt(bk * bk - 4 * ak * ck);
            if (diskr > 0)
            {
                x1 = (-bk + Math.Sqrt(diskr)) / (2 * ak);
                x2 = (-bk - Math.Sqrt(diskr)) / (2 * ak);
                Console.WriteLine($"Первый корень: {x1} | Второй корень: {x2}");
            }
            if (diskr == 0)
            {
                x1 = -bk / (2 * ak);
                Console.WriteLine("Один корень: " + x1);
            }
            else
            {
                Console.WriteLine("Нет корней");
            }

            Console.WriteLine("Задание 17. Среднее арифметическое и геометрическое");

            Console.Write("Введите первое число: ");
            int y1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int y2 = int.Parse(Console.ReadLine());
            double arifm = (y1 + y2) / 2;
            double geo = Math.Sqrt(y1 * y2);
            Console.Write("Среднее арифметическое = " + arifm);
            Console.Write("Среднее геометрическое = " + geo);

            Console.WriteLine("Задание 18. Точки на плоскости");
            Console.WriteLine("Координаты точки А(212; 324) | Координаты точки В(500; 100)");
            Console.WriteLine($"Расстояние между точками: {Math.Sqrt(((500 - 212) ^ 2) + ((100 - 324) ^ 2))}");

            Console.WriteLine("Задание 19. Переприсваивание");
            int a19 = 2;
            int b19 = 3;
            int c19 = 4;
            Console.WriteLine("a b c");
            Console.WriteLine($"{a19} {b19} {c19}");
            int d19 = b19;
            b19 = c19;
            c19 = a19;
            a19 = d19;
            Console.WriteLine($"{a19} {b19} {c19}");
            a19 = 2;
            b19 = 3;
            c19 = 4;
            d19 = b19;
            b19 = a19;
            a19 = c19;
            c19 = d19;
            Console.WriteLine($"{a19} {b19} {c19}");

            Console.WriteLine("Задание 20. Секунды");
            int seconds = int.Parse(Console.ReadLine());
            Console.WriteLine($"Прошло {(seconds / 3600)} часов");
            Console.WriteLine($"Прошло {((seconds % 3600) / 60)} минут");
            Console.WriteLine($"Прошло {(seconds % 60)} секунд");

            Console.WriteLine("Задание 21. Квадраты");
            Console.WriteLine(543 / 130 + " квадрата можно получить");

            Console.WriteLine("Задание 22. Число");
            Console.WriteLine("введите трёхначное число");
            int trehznch = int.Parse(Console.ReadLine());
            Console.WriteLine($"{trehznch % 10}{trehznch / 10}");

            Console.WriteLine("Задание 23. Число больше 999");
            Console.WriteLine("Введите число n > 999");
            int n = int.Parse(Console.ReadLine());
            if (n > 999)
            {
                Console.WriteLine($"{(n / 100)} сотен в числе");
                Console.WriteLine($"{n / 1000} тысяч в числе");
            }
            else
            {
                Console.WriteLine("Вы ввели число <= 999");
            }

            Console.WriteLine("Задание 24. Перестановки");
            Console.WriteLine("Введите четырёхзначное число");
            string numbers = Console.ReadLine();
            if (numbers.Length == 4)
            {
                Console.WriteLine("Обратное число: " + numbers[3] + numbers[2] + numbers[1] + numbers[0]);
                Console.WriteLine(numbers[1] + numbers[0] + numbers[3] + numbers[2]);
                Console.WriteLine(numbers[0] + numbers[2] + numbers[1] + numbers[3]);
                Console.WriteLine(numbers[2] + numbers[3] + numbers[0] + numbers[1]);

            }
            else
            {
                Console.WriteLine("Вы ввели не четырёхзначное число");
            }

            Console.WriteLine("Задание 25. Трехзначное число");
            Console.WriteLine("Введите число [100; 999], в разряде десятков которого нет 0");
            string trehznach = Console.ReadLine();
            int intrehznach = int.Parse(trehznach);
            if (intrehznach >= 100 && intrehznach <= 999 && trehznach != "0")
            {
                Console.WriteLine($"Результат: {trehznach[1] + trehznach[2] + trehznach[0]}");
            }
            else
            {
                Console.WriteLine("Число не удовлетворяет условиям");
            }

            Console.WriteLine("Задание 26. Часовые стрелки");
            Console.WriteLine("Сколько часов[0;23]?");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько минут[0;59]?");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Сколько секунд[0;59]?");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine($"На столько градусов повернётся стрелка: {((3600 * h + m * 60 + s) * 0.0083) % 360}");

            Console.WriteLine("Задание 27. Угол между лучом и стрелкой");
            Console.WriteLine("Введите минуту");
            int time = int.Parse(Console.ReadLine());
            Console.WriteLine(((time * 60) * 0.0083) % 360);
            Console.WriteLine($"Полных часов: {time / 60} | Полных минут:{time % 60}");

            Console.WriteLine("Задание 28. Наибольшее по модулю");
            Console.WriteLine("Введите 3 вещественных числа: ");
            double mod1 = Math.Abs(double.Parse(Console.ReadLine()));
            double mod2 = Math.Abs(double.Parse(Console.ReadLine()));
            double mod3 = Math.Abs(double.Parse(Console.ReadLine()));
            List<double> list = new List<double>();
            list.AddRange(new double[]
            {
                mod1, mod2, mod3
            });
            Console.WriteLine(list.Max());

            Console.WriteLine("Задание 29. Сумма наибольшего и наименьшего");
            double sum1 = double.Parse(Console.ReadLine());
            double sum2 = double.Parse(Console.ReadLine());
            double sum3 = double.Parse(Console.ReadLine());
            List<double> list2 = new List<double>();
            list2.AddRange(new double[]
            {
                sum1, sum2, sum3
            });
            Console.WriteLine($"Сумма наибольшего и наименьшего: {list2.Max() + list2.Min()}");

            Console.WriteLine("Задание 30. Делители натурального числа");
            Console.WriteLine("Введите натуральное число: ");
            int cnt = 0;
            int naturchislo;
            if (int.TryParse(Console.ReadLine(), out naturchislo))
            {
                for (int i = 1; i <= naturchislo; i++)
                    if (naturchislo % i == 0)
                    {
                        cnt++;
                    }
                Console.WriteLine($"У числа {naturchislo} - {cnt} натуральных делителей");
            }
            else
            {
                Console.WriteLine("Вы ввели не натуральное число");
            }

            Console.WriteLine("Задание 31. Кубическое уравнение");
            List<double> roots = new List<double>();
            double a31 = double.Parse(Console.ReadLine());
            double b31 = double.Parse(Console.ReadLine());
            double c31 = double.Parse(Console.ReadLine());
            double d31 = double.Parse(Console.ReadLine());
            int root = -100;
            do
            {
                if ((a31 * Math.Pow(root, 3) + (b31 * Math.Pow(root, 2)) + (c31 * root) + d31) == 0)
                {
                    roots.Add(root);
                }
            }
            while (root == 101);
            string str1 = "имеет " + Convert.ToString(roots.Count) + " корней";
            string str2 = "не имет корней";
            string str3;
            if (roots.Count > 0)
            {
                str3 = str1;
            }
            else
            {
                str3 = str2;
            }
            Console.WriteLine("Уравнение " + a31 + "x^3 + (" + b31 + "x^2) + (" + c31 + "x) + (" + d31 + ") " + str3 + " на участке [-100;100]");

            Console.WriteLine("Задание 32. Элемент арифметической прогрессии");
            Console.WriteLine("Введите первый элемент последовательности: ");
            double firstvalue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второй элемент последовательности: ");
            double secondvalue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите номер элемента последовательности: ");
            int elnumber = int.Parse(Console.ReadLine());
            double schet = firstvalue + ((secondvalue - firstvalue) * (elnumber - 1));
            Console.WriteLine($"Элемент прогресси под номером {elnumber} - {schet}");

            Console.WriteLine("Задание 33. Кредит");
            Console.WriteLine("Ответьте на воросы (1 - да, 0 - нет).");
            Console.WriteLine("Вы пенсионер?");
            string pensioner = Console.ReadLine();
            Console.WriteLine("Вы студент?");
            string student = Console.ReadLine();
            Console.WriteLine("Вы трудоустроены?");
            string job = Console.ReadLine();
            if ((pensioner == "1" && job == "1") || (student == "1" && job == "1") || (student == "1" && pensioner == "1"))
            {
                Console.WriteLine("Простите, мы не можем выдать вам кредит;((((((");
            }
            else
            {
                Console.WriteLine("Поздравляем!Кредит одобрен");
            }

            Console.WriteLine("Задание 34. Имя");
            Console.WriteLine("Как вас зовут?");
            Console.WriteLine(Console.ReadLine());
            Console.WriteLine("Как вас зовут?");
            Console.WriteLine("Привет, " + Console.ReadLine() + "!");

            Console.WriteLine("Задание 35. Гарри");
            Console.WriteLine("Как тебя зовут?");
            Console.WriteLine("Привет, " + Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Да");
            Console.ReadLine();
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Но могу показать");
            Thread.Sleep(1000);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ResetColor();

            Console.WriteLine("Задание 36.а. Штрихкод");
            int[] array = new int[13];

            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(0, 10);
            }
            array[12] = 0;
            int sumchet = 3 * (array[0] + array[2] + array[4] + array[6] + array[8] + array[10] + array[12]);
            int sumnechet = (array[1] + array[3] + array[5] + array[7] + array[9] + array[11]);
            int sumfinal = 10 - ((sumchet + sumnechet) % 10);
            Console.WriteLine("Контрольная цифра: " + sumfinal);

            Console.WriteLine("Задание 36.б. Штрихкод(ручное)");
            int[] array2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 12; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
            }
            int sumchet2 = 3 * (array2[0] + array2[2] + array2[4] + array2[6] + array2[8] + array2[10] + array2[12]);
            int sumnechet2 = (array2[1] + array2[3] + array2[5] + array2[7] + array2[9] + array2[11]);
            int sumfinal2 = 10 - ((sumchet2 + sumnechet2) % 10);
            Console.WriteLine("Контрольная цифра: " + sumfinal2);




        }
    }
}
