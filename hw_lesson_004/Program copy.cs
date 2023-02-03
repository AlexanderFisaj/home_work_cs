//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
int i;
Console.Write("Enter an integer: ");
int N = Convert.ToInt32(Console.ReadLine());
while (N < 0)
{
    Console.Write("Error!\nThe number must not be negative.!\nEnter another number: ");    
}
if (N % 2 == 0)
    i = 0;
else
    i = -1;
while (i < N)
{
Console.Write($"{N}, ");
N = N + 2;
}
