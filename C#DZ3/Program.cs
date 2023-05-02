//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
/*
void Palindrom(int num)
{
    int temp = num;
    int palindrom = 0;

    while (temp != 0)
    {
        int digit = temp % 10;
        palindrom = palindrom * 10 + digit;
        temp /= 10;
    }
    if (palindrom == num) 
        Console.WriteLine($"Число {num} - палиндром");
    else 
        Console.WriteLine($"Число {num} -  не палиндром");
}

Console.Write ("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
    Palindrom(number);
else Console.WriteLine("Ваше число не пятизначное!");
*/


//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
/*
double LongLine (int x1, int x2, int y1, int y2, int z1, int z2)
{
    double lengthAB = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2)+ (z1 - z2)*(z1 - z2));
    return lengthAB;
}

Console.WriteLine("Введите X для A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y для A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z для A: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите X для B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y для B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z для B: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LongLine(xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);

Console.WriteLine($"Расстояние AB = {dist:f3}");
*/


//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void CubeFinder ()
{
    Console.WriteLine("Введите число: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    if (numberN > 0)
    {
        int current_i = 1;
        while (current_i <= numberN)
            {
                int res = current_i*current_i*current_i;
                Console.Write($"{res:f0}, ");
                current_i ++;
            }
        Console.WriteLine("\b\b.");
    }
    else 
    {
        int current_i = 1;
        while (current_i >= numberN)
            {
                Console.Write(current_i*current_i*current_i + ", ");
                current_i --;
            }
        Console.WriteLine("\b\b.");
    }
}

CubeFinder();
*/