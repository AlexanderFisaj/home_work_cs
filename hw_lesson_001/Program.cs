//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//Решение:
Console.Clear();
Console.Write("Please enter the first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Please enter the second number: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a > b) Console.WriteLine($"larger umber -> {a}, smaller number -> {b}");
else Console.WriteLine($"larger umber -> {b}, smaller number -> {a}");
