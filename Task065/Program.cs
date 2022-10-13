/*  Задача 65: Задайте значения M и N. Напишите программу, которая 
    выведет все натуральные числа в промежутке от M до N.
    M = 1; N = 5 -> "1, 2, 3, 4, 5"
    M = 4; N = 8 -> "4, 6, 7, 8"                                */


void printRange(int N, int M)
{
    if (N > M)
    {
        return;
    }
    Console.Write($"{N}, ");
    printRange(N + 1, M);
}

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());


printRange(N, M);