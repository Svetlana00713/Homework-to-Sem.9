//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void RoadToN(int N, int M)
{
    if(N == M - 1)
    {
        return;
    }
    RoadToN(N,M+1);
    System.Console.Write($"{M} ");
}

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int M = 1;
RoadToN(N,M);

