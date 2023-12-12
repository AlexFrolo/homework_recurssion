
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return Ackermann(m - 1, 1);
        }
        else
        {
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }

    static void Main(string[] args)
    {
        int m, n;

        Console.Write("Введите значение m: ");
        m = int.Parse(Console.ReadLine());

        Console.Write("Введите значение n: ");
        n = int.Parse(Console.ReadLine());

        int result = Ackermann(m, n);
        Console.WriteLine($"Результат функции Аккермана для m={m} и n={n}: {result}");

        Console.ReadLine();
    }
}