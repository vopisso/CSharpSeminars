/*
int[] ChangeNums(int[] array)
{
    for (int i = 0; i < array.Lengthh; i++)
        array[i] *= (-1);
    return array;
}
*/
/*
Задача1 ==== Задайте массив. Напишите программу, которая определяет, присутствует ли заданное 
число в массиве.
*/

/*
int[] CreateRandomArray(int size, int min, int max)   // Метод создает массив случайных чисел
{
    int[] array = new int[size];
    for (int i = 0; i < size -1; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}
*/
/*
void CheckNumInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        {
            Console.WriteLine("The number you entered presents in array");
            break;
        }
    }
    Console.WriteLine("NO");
}


int[] array = CreateRandomArray(15, 1, 300);
CheckNumInArray(array, 15);
*/


int[] CreateRandomArray(int size, int min, int max)   // Метод создает массив случайных чисел
{
    int[] array = new int[size];
    for (int i = 0; i < size -1; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

int CountNumbers(int[] array, int min, int max)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= min && array[i] <= max)
        {
            counter++;
        }
    }
    return counter;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
/*
int[] myArray = CreateRandomArray(15, -10, 100);
ShowArray(myArray);
Console.WriteLine();
Console.WriteLine(CountNumbers(myArray, 10, 99));
*/



string CheckNumInArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == num)
        {
            return "YES";
        }
    }
    return "NO";
}


/*
Задача ===== Задайте одномерный массив из 15 случайных чисел. Найдите количество элементов массива,
 значения которых лежат в отрезке [10,99].
*/

int[] NewMagicArray(int[] array)
{
    int newSize = array.Length / 2;
    int[] newArray = new int[newSize];

    for (int i = 0, j = array.Length - 1; i < newSize; i++, j--)
    {
        newArray[i] = array[i] * array[j];
    }

    return newArray;
}

int[] arr = CreateRandomArray(6, 1, 9);
ShowArray(arr);

int[] newArr = NewMagicArray(arr);
ShowArray(newArr);
