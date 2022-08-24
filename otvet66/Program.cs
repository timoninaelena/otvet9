// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//  M = 1; N = 15 -> 120     M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());
int x = 0;
for (int i = M; i <= N; i++)
{
  x = x + i;
}
Console.Write($" Cумма натуральных элементов в промежутке = {x}");