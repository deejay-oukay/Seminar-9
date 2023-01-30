// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

using System;

namespace MyNameSpace
{
    class Task64
    {
        static private int InputInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        static private void PrintNextValue(int value)
        {
            if (value == 1)
                System.Console.WriteLine(value);
            else
            {
                System.Console.Write(value + ", ");
                if (value > 1)
                    PrintNextValue(value - 1);
                else
                    PrintNextValue(value + 1);
            }
        }

        static public void Main()
        {
            PrintNextValue(InputInt("Введите число N: "));
        }
    }
}

