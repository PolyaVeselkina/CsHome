//Задача 25: 
//Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.

/*
void DegFind (int a, int b)
{
    int i = 1;
    int deg = 1;

    while (i <= b)
    {
        deg *= a;
        i += 1;
    }
    
    Console.WriteLine ($"Число {a} в степени {b} равна {deg}"); 
}

Console.WriteLine("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numB = Convert.ToInt32(Console.ReadLine());

DegFind (numA, numB);
*/


//Задача 27: 
//Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.

/*
int SumFind (int num)
{
    int sum = 0;
    int temp = 0;

    while (num > 0)
    {
        temp = num % 10;        
        num = num / 10;         
        sum = sum + temp;       
    }
    return sum;
}

Console.WriteLine("Введиет число: ");
int user_num = Convert.ToInt32(Console.ReadLine());
int sum1;

if ( user_num >= 0)
{
    sum1 = SumFind (user_num); 
}
else
{
    sum1 = SumFind (user_num * (-1));
}

Console.WriteLine($"Сумма цифр в числе равна: {sum1}");
*/

















//Задача 29: 
//Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.

/*
int [] CreatNewArray (int size, int min, int max) 
{
    int [] array = new int[size]; 
    for (int i = 0; i < size; i++ )
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void ShowArray (int [] array)
{
    for(int i = 0; i < array.Length; i++ )
        Console.Write(array[i] + " ");
}

Console.WriteLine("Введите количество элементов: ");
int countOfElem = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите min значение: ");
int minVal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите max значение: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

int [] array1 = CreatNewArray(countOfElem, minVal, maxVal);
ShowArray(array1);
*/