//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
int i = 2;
Console.Write("Enter a number greater than zero: ");
int N = Convert.ToInt32(Console.ReadLine());
while (N < 1)
{
    Console.Write("Error!\nThe entered number does not match the request parameters.!\nEnter another number: ");
    N = Convert.ToInt32(Console.ReadLine());
}
if (N == 1)
    Console.Write("There is no even number to this number.");

while (i < N || i == N)
{
Console.Write($"{i}  ");
i = i + 2;
}
