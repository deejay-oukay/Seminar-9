// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using System;

namespace MyNameSpace
{
    class Task66
    {
        static int m, n, sum;
        static private int InputInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        static private void Sum(int from, int to)
        {
            sum += from;
            if (from < to)
            {
                Sum(from + 1, to);
            }
            else if (from > to)
            {
                Sum(from - 1, to);
            }
        }

        static public void Main()
        {
            m = InputInt("Введите число M: ");
            n = InputInt("Введите число N: ");
            Sum(m, n);
            System.Console.WriteLine($"Сумма чисел от {m} до {n}: {sum}");
        }
    }
}

