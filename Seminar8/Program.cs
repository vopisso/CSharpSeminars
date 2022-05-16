// Задача1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Задача2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//          В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] CreateMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}


int[,] SwapStrings(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        temp = matrix[0, i];
        matrix[0, i] = matrix[matrix.GetLength(0) -1, i];
        matrix[matrix.GetLength(0) -1, i] = temp;
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

/*
Console.Write("Input number of strings: ");
int numberOfStrings = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int numberOfColumns = Convert.ToInt32(Console.ReadLine());

int[,] newMatrix = CreateMatrix(numberOfStrings, numberOfColumns);

PrintMatrix(newMatrix);

Console.WriteLine();

SwapStrings(newMatrix);

PrintMatrix(newMatrix);
*/

// ================= Задача2 ==================

int[,] ChangeRowToColumn(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            result[i, j] = matrix[j, i];
        }
    }
    return result;
}

int[,] ChangeRowToColumnLight(int[,] matrix)
{
    int temp = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = i + 1; j < matrix.GetLength(1); j++)
        {
            temp = matrix[i, j];
            matrix[i, j] = matrix[j, i];
            matrix[j, i] = temp;
        }
    }
    return matrix;
}

Console.Write("Input number of strings: ");
int numberOfStrings = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of columns: ");
int numberOfColumns = Convert.ToInt32(Console.ReadLine());

int[,] newMatrix = CreateMatrix(numberOfStrings, numberOfColumns);

PrintMatrix(newMatrix);

Console.WriteLine();

int[,] swapMatrix = ChangeRowToColumnLight(newMatrix);

PrintMatrix(swapMatrix);






