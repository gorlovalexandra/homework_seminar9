/* Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

Console.WriteLine("Enter a natural number greater than 1:");
int N = int.Parse(Console.ReadLine());

void NumericInterval (int number)
{
    if (number < 0) Console.Write($"{number} not a natural number.");
    if (number == 0) return;
    Console.Write("{0,4}", number);
    NumericInterval (number - 1);
}

NumericInterval(N);