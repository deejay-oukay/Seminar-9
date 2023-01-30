// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using System;

namespace MyNameSpace
{
    class Task68
    {
        static private int InputInt(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }

        // Не понял в чём суть функции Аккермана. Видимо, она создана для того, чтобы показать что-то необычное в рекурсии...
        // Если алгоритм на 100% соответсвует задаче, то получаем переполнение стека, что для неправильно организованной рекурсии - нормально.
        // Но "желаемый результат", приведёный для примера в описании задачи, можем получать только, если поменяем аргументы функции местами.
        // Причём функция Аккермана в открытых источника описывается с аргументами именно в таком порядке - (n,m), а не (m,n)
        static private int Ackerman(int n, int m)
        {
            if (n == 0)
                return (m + 1);
            else if ((n != 0) && (m == 0))
                return Ackerman(n - 1, 1);
            else //if ((n > 0) && (m > 0))
                return Ackerman(n - 1, Ackerman(n, m - 1));
        }

        static public void Main()
        {
            System.Console.WriteLine(Ackerman(InputInt("Введите неотрицательное число N: "), InputInt("Введите неотрицательное число M: ")));
        }
    }
}

