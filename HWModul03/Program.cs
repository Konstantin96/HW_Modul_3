using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT2_2606
{
    class Program
    {

        static void Main(string[] args)
        {
            int nz;
            do
            {
                Console.Write("Введите номер задания: ");
                nz = Int32.Parse(Console.ReadLine());
                switch (nz)
                {
                    case 1:
                        {
                            task1();
                        }
                        break; ;

                    case 2:
                        {
                            task2();
                        }
                        break;
                    case 3:
                        {
                            task3();
                        }
                        break;

                    case 4:
                        {
                            task4();
                        }
                        break;

                    case 5:
                        {
                            task5();
                        }
                        break;

                    case 6:
                        {
                            task6();
                        }
                        break;

                    case 7:
                        {
                            task7();
                        }
                        break;

                    case 8:
                        {
                            task8();
                        }
                        break;

                    case 9:
                        {
                            task9();
                        }
                        break;

                    case 10:
                        {
                            task10();
                        }
                        break;
                }
            } while (nz > 0);
        }

        static void task1()
        {
            Console.WriteLine("Введите символ: ");

            List<char> l = new List<char>();
            int count = 0;
            char x = ' ';
            while (x != '.')
            {
                x = Char.Parse(Console.ReadLine());
                l.Add(x);
                if (x == ' ')
                    count++;
            }
            Console.WriteLine("Count of '{0}'", count);

        }

        static void task2()
        {
            int[] x = { 2, 3, 4, 5 };
            int sum = 0, pr = 1;
            for (int i = 0; i < 4; i++)
            {
                sum += x[i];
                pr *= x[i];
            }
            Console.WriteLine("sum: {0}\n pr: {1}", sum, pr);
        }

        static void task3()
        {
            Console.WriteLine("Введите число: ");
            string x = Console.ReadLine();
            char[] arr = x.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine("Reverse: {0} ", new string(arr));
        }

        static void task4()
        {

            Console.Write("Введите сторону квадрата: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Периметр: {0}", a * 4);

        }

        static void task5()
        {
            Console.Write("Enter a date: ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            DateTime yesterday = date.Date.AddDays(-1);
            Console.WriteLine("дату предыдущего дня: {0} ", yesterday);
            Console.WriteLine("------------------------------------------------------");
            DateTime nextday = date.Date.AddDays(+1);
            Console.WriteLine("дату следующего дня: {0} ", nextday);

        }

        static void task6()
        {
            int[] funt = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] kg = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < 10; i++)
            {
                kg[i] = funt[i] * 453;
                Console.WriteLine("{0} pound\t= {1} kg", funt[i], kg[i]);
            }
        }

        static void task7()
        {
            int count = 234;
            Console.WriteLine("Full weeks: {0}", count / 7);

        }

        static void task8()
        {
            Console.Write("Enter the x: ");
            double x = double.Parse(Console.ReadLine());
            double y = 7 * x * x - 3 * x + 6;
            Console.WriteLine("y = {0}", y);
        }

        static void task9()
        {
            Console.WriteLine("Введите 2значное число: ");
            string a = Console.ReadLine();
            char[] arr = a.ToCharArray();
            int a1 = Int32.Parse(arr[0].ToString());
            int a2 = Int32.Parse(arr[1].ToString());

            if (a1 > a2)
                Console.WriteLine("Первая больше.");
            else if (a1 < a2)
                Console.WriteLine("Вторая больше.");
            else
                Console.WriteLine("Равны.");
        }

        static void task10()
        {
            Console.WriteLine("введите 2-ух значное число: ");

            int a = Int32.Parse(Console.ReadLine());

            if (a % 2 == 0)
                Console.WriteLine("Число четное.");
            else
            {
                Console.WriteLine("Число не четное.");
                int k = a / 10;
                if (a - k * 10 == 7)
                    Console.WriteLine("Число оканчивается на 7.");
                else
                    Console.WriteLine("Число не оканчивается на 7.");
            }

        }
    }
}