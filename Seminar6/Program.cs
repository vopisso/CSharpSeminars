/*
bool IsTriangleExist(int a, int b, int c)
{
    if(a < b + c && b < a + c && c < b + a)
    {
        return true;
    }
    return false;
}

if(IsTriangleExist(1, 2, 3))
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}
*/

int[] CreateRandomArray(int size, int min, int max)   // Метод создает массив случайных чисел
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] ReverseArray(int[] array)
{
   int temp;

    for (int i = 0, j = array.Length - 1; i < array.Length / 2; i++, j--)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}
/*
int[] testArray = CreateRandomArray(10, 1, 10);
ShowArray(testArray);
//Console.WriteLine();
ReverseArray(testArray);
ShowArray(testArray);
*/
/*
void GetFibonacci(int num)
{
    int n1 = 1;
    int n2 = 1;
    int count = 3;

    while (count < n)
    {
        count = 
    }
}
*/

int[] GetFibonacci(int num)
{
    int[] array = new int[num];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < num; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

int[] newArray = GetFibonacci(25);
ShowArray(newArray);