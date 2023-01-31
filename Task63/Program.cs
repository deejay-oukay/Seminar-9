// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

using System;

namespace MyNameSpace
{
    class Task63
    {
        static int n = 0;

        static private int InputInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        static private void PrintNextValue(int value)
        {
            if (value == n)
                System.Console.WriteLine(value);
            else
            {
                System.Console.Write(value + ", ");
                if (value > n)
                    PrintNextValue(value - 1);
                else
                    PrintNextValue(value + 1);
            }
        }

        static public void Main()
        {
            n = InputInt("Введите число N: ");
            PrintNextValue(1);
        }
    }
}

