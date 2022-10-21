/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Enter a number m:");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Enter a number n:");
int n = int.Parse(Console.ReadLine());

int AckFun(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return AckFun(m - 1, 1);
  else return AckFun(m - 1, AckFun(m, n - 1));
}

int ackermanFunction = AckFun(m, n);
Console.Write($"Ackerman function = {ackermanFunction} ");