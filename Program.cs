

using System;
using System.Text;
using static System.Console;

namespace HW_Introduction
{
    internal class Program
    {
        static void Main()
        {
            Problem1();
            Problem2();
            Problem3();
            Problem4();
            Problem5();
            Problem6();
            Problem7();

            OutputEncoding = Encoding.Unicode;
            ReadKey(true);

        }


        static void Problem1()
        {
            for (int i = 1; i <= 100; i++)
            {
                string result = i.ToString();
                if (i % 3 == 0)
                {
                    result = "Fizz";
                    if (i % 5 == 0) result = "FizzBuzz";
                }
                else if (i % 5 == 0) result = "Buzz";
                WriteLine(result);
            }
            ReadKey();
        } 
        
        static void Problem2()
        {
            Write("Число: ");
            double num = Convert.ToInt32(ReadLine());
            Write("Відсоток: ");
            double vid = Convert.ToInt32(ReadLine());
            double? sum;
            sum = (num * vid) / 100;
            WriteLine($"{vid}відсотків від {num} = {sum}");
        } 
        
        static void Problem3()
        {
            Write("Число 1: ");
            int num1 = Convert.ToInt32(ReadLine());
            Write("Число 2: ");
            int num2 = Convert.ToInt32(ReadLine());
            Write("Число 3: ");
            int num3 = Convert.ToInt32(ReadLine());
            Write("Число 4: ");
            int num4 = Convert.ToInt32(ReadLine());

            WriteLine($"Число {num1}{num2}{num3}{num4}");
        }

        static void Problem4()
        {
            Write("Число 1: ");
            int num1 = Convert.ToInt32(ReadLine());
            Write("Число 2: ");
            int num2 = Convert.ToInt32(ReadLine());
            Write("Число 3: ");
            int num3 = Convert.ToInt32(ReadLine());
            Write("Число 4: ");
            int num4 = Convert.ToInt32(ReadLine());

        }

        static void Problem5()
        {
            Write("Enter date->");
            string? dateTime = ReadLine();
            DateTime date = DateTime.Parse(dateTime);
            WriteLine($"День: {date.Day} \t Місяць:{date.Month}\t Рік:{date.Year} \t День тижня:{date.DayOfWeek}");
        } 
        
        static void Problem6()
        {
            Write("Enter temperature: ");
            double temp;
            temp = Convert.ToDouble(ReadLine());
            WriteLine("Choose how to convertate 1.Cels to Far 2.Far to Cel");
            int? choice;
            choice = Convert.ToInt32(ReadLine());
            switch (choice)
            {
                case 1:
                    double result = temp * 1.8 + 32;
                    WriteLine($"Farengeith: {result}");
                    break;

                case 2:
                    double resultt = (temp - 32) / 1.8;
                    WriteLine($"Celsium: {resultt}");
                    break;
            }
        }
        static void Problem7()
        {
            Write("Перший номер: ");
            int num1 = Convert.ToInt32(ReadLine());
            Write("Другий номер: ");
            int num2 = Convert.ToInt32(ReadLine());
            if (num1 > num2)
            {
                int tmp = num1;
                num1 = num2;
                num2 = tmp;
                WriteLine("Числа змінено!");
            }
            WriteLine("Числа: ");
            for (int i = num1; i <= num2; i++)
            {
                if (i % 2 == 0) Write($" {i}");
            }
        }
    }
}