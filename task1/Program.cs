Console.WriteLine("введите пятизначное число: ");
int number =  Convert.ToInt32 (Console.ReadLine()); 

int num12 = number / 1000;
int digit1 = num12 / 10;
int digit2 =  num12 % 10;

int num45 = number % 100;
int digit4 = num45 / 10;
int digit5 = num45 % 10;
if (digit1 == digit5)
{
        if (digit2 == digit4)
    {
        Console.WriteLine("является паллиндромом");
    }
}

else
{
    Console.WriteLine("не является");
}