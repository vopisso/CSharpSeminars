/*
void ShowNumber()
{
    int num = new Random().Next(10, 99);
    int firstNum = num / 10;
    int secondNum = num % 10;

    Console.Write(num + " -> ");

    if(firstNum > secondNum)
    {
        Console.WriteLine(firstNum);
    }
    else
    {
        Console.WriteLine(secondNum);
    }
}

ShowNumber();
*/

int ShowNumber(int n)
{
    int firstNum = n / 10;
    int secondNum = n % 10;

    Console.Write(n + " -> ");

    if(firstNum > secondNum)
    {
        return firstNum;
    }
    else
    {
        return secondNum;
    }
}


int num = new Random().Next(10, 99);
//int a = ShowNumber(num);

Console.Write(ShowNumber(num));