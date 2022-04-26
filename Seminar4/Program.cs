/*
Задача1: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
*/
/*
int NaturalSum(int a)
{
    int sum = 0;
    if(a < 1) return 0;
    else
    {
        for (int i = 1; i <= a; i++)
        {
            sum = sum + i;
            //sum +=i; (делает то же, что и стр.13)
        }
        return sum;
    }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sum of elements is " + NaturalSum(number));
*/

/*
Задача 2: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
*/
/*
int GetDigitAmount(int num)
{
    int count = 0;
    while(num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Amount of digits is " + GetDigitAmount(number));
*/

/*
Задача 3: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
*/
/*
int GetFactorial(int num)
{
    int faktor = 1;
    if(num < 0) return 0;
    else
    {
        for (int i = 1; i <= num; i++)
        {
            faktor *= i;
        }
        return faktor;
    }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Factorial is " + GetFactorial(number));
*/

/*
Задача 4: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и 
единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

/*
Задача 5: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
Найдите сумму отрицательных и положительных элементов массива.
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


int[] CreateArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Input i element ");
        array[i] = Convert.ToInt32(Console.ReadLine());
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

void FindSumOfElements(int[] array)
{
    int plusSum = 0;
    int minSum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)
            plusSum += array[i];
        else
            minSum += array[i];
    }
    Console.WriteLine("Sum of positive elements is " + plusSum);
    Console.WriteLine("Sum of negative elements is " + minSum);
}

Console.Write("Input array size ");
int[] myArray1 = CreateArray(Convert.ToInt32(Console.ReadLine()));
ShowArray(myArray1);
FindSumOfElements(myArray1);
//int[] myArray = CreateRandomArray(6, -5, 5);
//ShowArray(myArray);
//FindSumOfElements(myArray);
*/

//===================================================================================================

// Homework #3 Task #1
/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли 
оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

/*
void CheckPalindrom(int num)
{
    int n1 = num / 10000 % 10;
    int n2 = num / 1000 % 10;
    int n4 = num / 10 % 10;
    int n5 = num % 10;

    if(num < 10000 || num > 99999)
    {
        Console.WriteLine("Incorrect input!");
    }
    else if(n1 == n5 && n2 == n4)
    {
        Console.WriteLine("The number " + num + " is a palindrome");
    }
    else
    {
        Console.WriteLine("The number " + num + " is NOT a palindrome");
    }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

CheckPalindrom(number);
*/

//**************************************************************************************************

/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

/*
void GetCubesOfNumber(int num)
{
    int count = 1;
    int a;
    Console.Write(num + " -> ");
    while(count <= num)
    {
        a = Convert.ToInt32(Math.Pow(count, 3));
        Console.Write(a);
        if(count < num) Console.Write(", ");
        count++;
    }

}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1)
{
    Console.WriteLine("Incorrect input");
}
else
{
    GetCubesOfNumber(number);
}
*/

/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между 
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
/*
double GetSegmentLength(double xA, double yA, double zA, double xB, double yB, double zB)
{
    double segmentX = xB - xA;
    double segmentY = yB - yA;
    double segmentZ = zB - zA;
    double segmentAB = Math.Sqrt((segmentX * segmentX) + (segmentY * segmentY) + (segmentZ * segmentZ));
    return segmentAB;
}

Console.Write("Input xA ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yA ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zA ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xB ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yB ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input zB ");
double zB = Convert.ToDouble(Console.ReadLine());


double aB = GetSegmentLength(xA, yA, zA, xB, yB, zB);
Console.WriteLine("segment A (" + xA + "," + xB + "," + zA + ")" + "; B (" + yA + "," + yB +
                  "," + zB + ")" + " length -> " + aB);
*/