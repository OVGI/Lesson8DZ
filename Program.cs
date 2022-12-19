/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка          */

int[,] array = new int[4, 5];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();

int imin = 0;
int min = 0;
for (int i = 0; i < array.GetLength(1); i++)
    min += array[0, i];
Console.Write($"[{0}]={min}\n");

for (int i = 1; i < array.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        sum += array[i, j];
    Console.Write($"[{i}]={sum}\n");
    if (sum < min)
    {
        min = sum;
        imin = i;
    }
}
Console.Write($"{imin} строка");