﻿//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.Write("Input number: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a % 2 == 0)
    Console.Write($"YES, the number is even!");
else
Console.Write($"NO, the number is NOT even!");
