/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

Console.WriteLine("Enter a number M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a number N:");
int numberN = int.Parse(Console.ReadLine());

void SumOfElements (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"The sum of natural elements in the gap from M to N: {sum}");
        return;
    }
    sum = sum + (M++);
    SumOfElements(M, N, sum);
}

SumOfElements(numberM, numberN, 0);
