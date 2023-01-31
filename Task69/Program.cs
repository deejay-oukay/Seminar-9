// Напишите программу, которая на вход принимает числа A и B и возводит число A в степень B с помощью рекурсии
// A = 3; B = 5 -> 243 (3 в 5-й степени)
// A = 2; B = 3 -> 8

using System;

namespace MyNameSpace
{
    class Task69
    {
        static int a, b;
        static private int InputInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        static private int Exponentiation(int number, int currentPower = 1)
        {
            if (currentPower < b)
                number = Exponentiation(number * a, currentPower + 1);
            return number;
        }

        static public void Main()
        {
            a = InputInt("Введите число A: ");
            b = InputInt("Введите число B: ");
            System.Console.WriteLine(Exponentiation(a));
        }
    }
}

