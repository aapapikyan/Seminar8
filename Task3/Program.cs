// Задача 3: Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.

int[,] CreateMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(-9, 10);
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

int[,] MatrixMult(int[,] matrixA, int[,] matrixB)
{
    int[,] result = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for(int t = 0; t < matrixA.GetLength(1); t++)
            {
                sum = sum + matrixA[i,t]*matrixB[t,j];
            }
            result[i, j] = sum;
        }
    }
    return result;
}
int valid = 4;
int[,] matrixA = CreateMatrix(2, valid);
int[,] matrixB = CreateMatrix(valid, 3);
Console.WriteLine("Матрица А:");
PrintArray(matrixA);
Console.WriteLine("Матрица В:");
PrintArray(matrixB);
Console.WriteLine("Результат произведения матриц");
PrintArray(MatrixMult(matrixA,matrixB));
