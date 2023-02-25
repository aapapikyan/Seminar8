// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrix()
{
    int[,] matrix = new int[4, 3];
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

int CheckSum(int[,] matrix)
{
    int summax = 0;
    int rowmax = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumrow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumrow = sumrow + matrix[i, j];
        }
        if (summax < sumrow)
        {
            summax = sumrow;
            rowmax = i;
        }
    }
    return rowmax;
}

int[,] matrix = CreateMatrix();
PrintArray(matrix);
Console.WriteLine($"Максимальная сумма на строке № {CheckSum(matrix) + 1}");
