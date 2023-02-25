// Задача 4: * Напишите программу, которая заполнит спирально квадратный массив.

int[,] CreateMatrix(int size)
{
    int[,] matrix = new int[size, size];
    matrix[0, 0] = 1;
    for (int t = 0; t < 2; t++)
    {
        for (int i = 1; i < size-t; i++) //первый вправо
        {
            if(t==0) {matrix[t, i] = matrix[t, i - 1] + 1;}
            else {matrix[t, i+t-1] = matrix[t, i - 1] + 1;}
        }
        for (int i = 1+t; i < size-t; i++) //первый вниз
        {
            matrix[i, size-t-1] = matrix[i - 1, size-1-t] + 1;
        }
        for (int i = size-1-t; i > t; i--) //первый влево
        {
            matrix[size-1-t, i - 1] = matrix[size-1-t, i] + 1;
        }
        for (int i = size-1-t; i > 1+t; i--) // первый вверх
        {
            matrix[i - 1, t] = matrix[i, t] + 1;
        }
        // for (int i = 1; i < size-t; i++) //второй вправо
        // {
        //     matrix[t, i] = matrix[t, i - 1] + 1;
        // }
        // for (int i = 1+t; i < size-t; i++) //второй вниз
        // {
        //     matrix[i, size-t-1] = matrix[i - 1, size-1-t] + 1;
        // }
        // for (int i = size-1-t; i > t; i--) //второй влево
        // {
        //     matrix[size-1-t, i - 1] = matrix[size-1-t, i] + 1;
        // }
        // for (int i = size-1-t; i > 1+t; i--) // второй вверх
        // {
        //     matrix[i - 1, t] = matrix[i, t] + 1;
        // }
        // for (int i = 2; i < 3; i++) //третий вправо
        // {
        //     matrix[2, i] = matrix[2, i - 1] + 1;
        // }
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

PrintArray(CreateMatrix(7));
