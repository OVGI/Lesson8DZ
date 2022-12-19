/* Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18      */

int[,] a = new int[3, 2] { { 3, 5 }, { 4, 3 }, { 2, 8 } };
int[,] b = new int[2, 3] { { 4, 6, 3 }, { 5, 7, 2 } };
int[,] c = new int[a.GetLength(0), b.GetLength(1)];
for (int i = 0; i < c.GetLength(0); i++)
{
    for (int j = 0; j < c.GetLength(1); j++)
    {
        int sum = 0;
        for (int r = 0; r < a.GetLength(1); r++)
        {
            sum += a[i, r] * b[r, j];
        }
        c[i, j] = sum;
    }
}

for (int i = 0; i < c.GetLength(0); i++)
{
    for (int j = 0; j < c.GetLength(1); j++)
        Console.Write($"{c[i, j]} ");
    Console.WriteLine();
}