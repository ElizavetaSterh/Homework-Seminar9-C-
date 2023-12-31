﻿// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string Factorial(int n, int start)
{
    if (n <= start) return start.ToString();
    return Factorial(n, start + 1) + ", " + start;
}
int GetInput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int n = GetInput("Введите число: ");
int start = 1;  
Console.WriteLine($"N = {n} -> {Factorial(n, start)}");




