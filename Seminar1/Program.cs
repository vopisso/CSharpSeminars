/*

// Задача 1 - Ввод целого числа и вывод квадрата этого числа

Console.WriteLine("Input integer number");
int num = Convert.ToInt32(Console.ReadLine());

int result = num * num;

Console.WriteLine("Result is " + result);
*/

/*
//Задача 2 - На вход принимает 2 числа и проверяет является ли первое число квадратом другого

Console.Write("Input first integer");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2) 
    Console.WriteLine("First number is a quad of second number");
else
    Console.WriteLine("First number is NOT a quad of second number");
*/


/*
//Задача 3 - Пользователь вводит номер лня недели, на консоль выводится название дня недели

Console.Write("Input number of weak day ");
int day = Convert.ToInt32(Console.ReadLine());

if(day > 7 || day < 1)
{
    Console.WriteLine("Incorrect day number!");
}
else
{
    if(day == 1)
        Console.WriteLine("It's Monday");
    if(day == 2)
        Console.WriteLine("It's Tuesday");
    if(day == 3)
        Console.WriteLine("It's Wensday");
}
*/


/*
//Задача 4 - Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Input integer number ");
int num = Convert.ToInt32(Console.ReadLine());
int current;
if(num < 1)
{
    current = num;
    num = num * (-1);
}
else
{
    current = -1 * num;
}

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/


/*
//Задача 5 - Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа

Console.Write("Input integer number ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100 || num > 999)
{
    Console.WriteLine("Incorrect number");
}
else
{
    int result = num % 10;
    Console.WriteLine("Resulted number is " + result);
}
*/

Console.Write("Input integer number > 1  ");
int number = Convert.ToInt32(Console.ReadLine());
int current = 1;

if(number <= 1)
{
    Console.WriteLine("Incorrect number!");
}
else
{
    while (current <= number)
    {
        if (current % 2 == 0)
        {
            Console.Write(current);
        }
        if(current % 2 == 0 && (current + 2) <= number)
        {
            Console.Write(", ");
        }
        current++;
    }
}