/*
Задача1 - Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка
*/

/*
int FindQvart(int x, int y)
{
    if(x > 0 && y > 0)
        return 1;
    else if(x < 0 && y > 0)
        return 2;
    else if(x < 0 && y < 0)
        return 3;
    else if(x > 0 && y < 0)
        return 4;
    else
        return 0;
}

Console.Write("Input X coordinate ");
int xDot = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coordinate ");
int yDot = Convert.ToInt32(Console.ReadLine());

int quartNum = FindQvart(xDot, yDot);

if(quartNum == 0)
{
    Console.WriteLine("Dot located on axes!");
}
else
{
    Console.WriteLine("Number of quart is " + quartNum);
}
*/



/*
Задача 2 - Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
*/
/*
void ShowDiapazone(int quorter)
{  
    if(quorter == 1)
        Console.WriteLine("x > 0; y > 0");
    else if(quorter == 2)
        Console.WriteLine("x < 0; y > 0");
    else if(quorter == 3)
        Console.WriteLine("x < 0; y < 0");
    else if(quorter == 4)
        Console.WriteLine("x > 0; y < 0");
    else
        Console.WriteLine("Incorrect input");
}

Console.Write("Input quorter ");
int quadNum = Convert.ToInt32(Console.ReadLine());

ShowDiapazone(quadNum);
*/

/*
Задача3 - Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 2D пространстве.
*/
/*
double GetSegment(double xA, double yA, double xB, double yB)
{
    double segmentX = xB - xA;
    double segmentY = yB - yA;
    double segmentAB = Math.Sqrt((segmentX * segmentX) + (segmentY * segmentY));
    return segmentAB;
}

Console.Write("Input xA ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yA ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Input xB ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Input yB ");
double yB = Convert.ToDouble(Console.ReadLine());

double aB = GetSegment(xA, yA, xB, yB);
Console.WriteLine(aB);
*/

/*
Задача4 - Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов 
чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/


void GetSquare(int num)
{
    int count = 1;
    int a;
    while(count <= num)
    {
        a = count * count;
        Console.Write(a);
        if(count < num)
        {
            Console.Write(", ");
        }
        else
        {
            Console.Write(".");
        }
        count++;
    }
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number < 1)
    Console.WriteLine("Incorrect input");
else
    GetSquare(number);
