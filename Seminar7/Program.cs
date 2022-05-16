/*
int SumOfDiagonal(int[,] quad)
{
    int sum = 0;

    for (int i = 0; i < quad.GetLength(0); i++)
    {
        sum += quad[i,i];    
    }
    return sum;
}

Console.WriteLine("Input size of matrix: ");

int size = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[size,size];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0, 10);
        Console.Write(matrix[i,j] + "  ");
    }
    Console.WriteLine();
}

Console.WriteLine(SumOfDiagonal(matrix));
*/

/*
Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n.
 Выведите полученный массив на экран.
 */

void CreateArray(int size1, int size2)
{
    int[,] array = new int[size1, size2];

    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            array[i,j] = i + j;
            Console.Write(array[i,j] + "  ");
        }
        Console.WriteLine();
    }
}

CreateArray(10, 10);





/*
Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы 
на их квадраты.
*/

int[,] CreateArray2(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
    {
        for (int j = 0; j < array.GetLength(1); j+=2)
        {
            array[i,j] *= array[i,j];
        }
        Console.WriteLine();
    }
    return array;
}
