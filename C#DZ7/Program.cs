//Задача 47
//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double [,] Create2DArray () 
{
    Console.WriteLine("Введите кол-во строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите кол-во столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимум: ");
    int minVal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите максимум: ");
    int maxVal = Convert.ToInt32(Console.ReadLine());

    double [,] created2Array = new double [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            created2Array[i,j] = new Random().Next(minVal, maxVal + 1) + new Random().NextDouble();
        }
    }
    return created2Array;
}

void Print2Array (double [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i ++)
    {
        for (int j = 0; j < array2d.GetLength(1); j ++)
        {
            Console.Write($"{array2d [i,j]:f2} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [,] new2dArray = Create2DArray();
Print2Array(new2dArray);
*/

//Задача 50
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
int [,] Create2DArray (int rows, int columns, int min, int max)
{
    int [,] created2Array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            created2Array[i,j] = new Random().Next(min, max + 1);
    return created2Array;
}

void Print2DArray (int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i ++)
    {
        for (int j = 0; j < array2d.GetLength(1); j ++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ElemSearch (int [,] array2D)
{
    Console.WriteLine("Введите строку: ");
    int numRows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите столбец: ");
    int numColumns = Convert.ToInt32(Console.ReadLine());

    if (numRows < array2D.GetLength(0) && numColumns < array2D.GetLength(1))
        Console.WriteLine($"Ваше число:{array2D[numRows,numColumns]}"); 
    else Console.WriteLine("Нет такого числа в массиве!");                           
}

int rowsN = new Random().Next(2, 5);
int columnsN = new Random().Next(2, 5);
int minV = new Random().Next(0, 5);
int maxV = new Random().Next(12, 20);

int [,] newArray = Create2DArray(rowsN, columnsN, minV, maxV);
Print2DArray(newArray);
ElemSearch(newArray);
*/
//Задача 52 
//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int [,] Create2DArray (int rows, int columns, int min, int max)
{
    int [,] created2Array = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            created2Array[i,j] = new Random().Next(min, max + 1);
    return created2Array;
}

void Print2DArray (int [,] array2d)
{
    for (int i = 0; i < array2d.GetLength(0); i ++)
    {
        for (int j = 0; j < array2d.GetLength(1); j ++)
        {
            Console.Write(array2d[i,j] + "  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

double [] FindAve (int [,] aveArray)
{
   
    double [] findAve = new double [aveArray.GetLength(1)];

    for (int j = 0; j < aveArray.GetLength(1); j ++)
    {   
        int sum = 0;

        for (int i = 0; i < aveArray.GetLength(0); i ++)
            sum = sum + aveArray[i,j];
        findAve[j] =Math.Round((double) sum / aveArray.GetLength(0), 2);
    }    
    return findAve;
} 

void ShowArrayAve (double [] aveArray1)
{
    Console.Write ("Среднее арифметическое столбцов: ");
    for (int i = 0; i < aveArray1.Length; i++)
        Console.Write (aveArray1[i] + "  ");
    Console.WriteLine();
}

int rowsN = new Random().Next(2, 5);
int columnsN = new Random().Next(2, 5);
int minV = new Random().Next(0, 5);
int maxV = new Random().Next(12, 20);

int [,] newArray = Create2DArray(rowsN, columnsN, minV, maxV);
Print2DArray(newArray);
double [] newArrayAve = FindAve(newArray);
ShowArrayAve(newArrayAve);
*/






