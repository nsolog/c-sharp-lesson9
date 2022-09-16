// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

if (N < M)
{
    while (N <= M)
    {
        if (N > 0) Console.Write($"{N}, ");
        N++;
    }
}
else
{
    Console.WriteLine("В данном промежутке нет натуральных чисел");
}