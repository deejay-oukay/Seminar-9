// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

using System;

namespace MyNameSpace
{
    class Task65
    {
        static int m, n;
        static private int InputInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        static private void PrintNextValue(int from, int to)
        {
            if (from == to)
                System.Console.WriteLine(to);
            else
                System.Console.Write(from+", ");
            if (from < to)
            {
                PrintNextValue(from + 1, to);
            }
            else if (from > to)
            {
                PrintNextValue(from - 1, to);
            }
        }

        static public void Main()
        {
            m = InputInt("Введите число M: ");
            n = InputInt("Введите число N: ");
            PrintNextValue(m, n);
        }
    }
}

