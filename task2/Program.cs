// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M < N)
{
    int multiple = 1;
    while (M <= N)
    {
        if (M > 0) multiple *= M;
        M++;
    }
    Console.Write($"Произведение всех натуральных чисел в прромежутке M:N = {multiple}");
}
else
{
    Console.WriteLine("В указанном промежутке нет натуральных чисел");
}