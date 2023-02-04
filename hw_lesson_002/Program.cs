// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("Please enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the third number: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b & a > c) Console.WriteLine($"max = {a}");
else if (b > c) 
    Console.WriteLine($"max = {b}");
else
    Console.WriteLine($"max = {c}");

Console.WriteLine("End");