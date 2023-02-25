// Задача 1: Задайте двумерный массив. Напишите программу,
// которая упорядочивает по убыванию элементы каждой строки двумерного массива.

int[,] CreateMatrix()
{
    int[,] matrix = new int[4, 5];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return (matrix);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Sort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int t = 0; t < matrix.GetLength(1) - 1; t++)
            {
                if (matrix[i, t] < matrix[i, t + 1])
                {
                    int max = matrix[i, t];
                    matrix[i, t] = matrix[i, t + 1];
                    matrix[i, t + 1] = max;
                }
            }
        }
    }
    return matrix;
}

int[,] matrix = CreateMatrix();
PrintArray(matrix);
Console.WriteLine("Массив со строками по убыванию:");
PrintArray(Sort(matrix));
