﻿//Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//Использовать рекурсию, не использовать циклы

using System;

class Program
{
    static void Main(string [] args)
    {
        Console.WriteLine("Введите значение M:");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите значение N:");
        int n = int.Parse(Console.ReadLine());

        PrintNumbers(m, n);

        Console.ReadLine();
    }

    static void PrintNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNumbers(m + 1, n);
        }
    }
}