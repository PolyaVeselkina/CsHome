//Задача 34: 
//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int [] CreatArray (int size, int minVal, int maxVal) 
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal + 1);
    return newArray;
}

void ShowArray (int [] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write (array1[i] + " ");
    Console.WriteLine();
}

int CountEvenNum (int [] array)
{
    int countEvenNum = 0;
    for ( int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            countEvenNum += 1;
    return countEvenNum;
}

int sizeArray = new Random().Next(4, 10);
int min = 100;
int max = 999;

int [] createdArray = CreatArray(sizeArray, min, max);
ShowArray(createdArray);
Console.WriteLine($"Количество четных чисел в массиве равно {CountEvenNum(createdArray)}");
*/


//Задача 36: 
//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
/*
int [] CreatArray (int size, int minVal, int maxVal) 
{
    int [] newArray = new int [size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal + 1);
    return newArray;
}

void ShowArray (int [] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write (array1[i] + " ");
    Console.WriteLine();
}

int SumOddIndex (int [] array)
{
    int sumOddIndex = 0;
    for (int i = 1; i < array.Length; i += 2)
        sumOddIndex += array[i];
    return sumOddIndex;
}

int sizeArray = new Random().Next(4, 20);
int min = new Random().Next(-10, 0);
int max = new Random().Next(20, 40);

int [] createdArray = CreatArray(sizeArray, min, max);
ShowArray(createdArray);
Console.WriteLine($"Сумма элементов на нечетных позициях равна {SumOddIndex(createdArray)}");
*/


//Задача 38: 
//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
/*
double [] CreatArray (int size, int minVal, int maxVal) 
{
    double [] newArray = new double [size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minVal, maxVal + 1) + new Random().NextDouble();
    return newArray;
}

void ShowArray (double [] array1)
{
    for (int i = 0; i < array1.Length; i++)
        Console.Write ($"{array1[i]:f3} ");
    Console.WriteLine();
}

double Min (double [] array)
{
    double minNum = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] < minNum) 
            minNum = array[i]; 
    return minNum;     
}

double Max (double [] array)
{
    double maxNum = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > maxNum) 
            maxNum = array[i];
    return maxNum;     
}

int sizeArray = new Random().Next(4, 20);
int min = new Random().Next(1, 5);
int max = new Random().Next(15, 20);

double [] createdArray = CreatArray(sizeArray, min, max);
ShowArray(createdArray);
double diff = Max(createdArray) - Min(createdArray);
Console.WriteLine($"Разница между max и min элементом равна {diff:f3}");
*/
