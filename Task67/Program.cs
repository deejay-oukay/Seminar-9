// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр
// 453 -> 12
// 45 -> 9

using System;

namespace MyNameSpace
{
    class Task67
    {
        static private int InputInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        static private int SumOfDigits(int number, int currentSum = 0)
        {
            int remainder = number % 10;
            currentSum += remainder;
            if ((number / 10) > 0)
                currentSum = SumOfDigits(number/10,currentSum);
            return(currentSum);
        }

        static public void Main()
        {
            System.Console.WriteLine(SumOfDigits(InputInt("Введите число: ")));
        }
    }
}

