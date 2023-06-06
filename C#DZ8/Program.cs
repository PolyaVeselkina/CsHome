//Задача 54: 
//Задайте двумерный массив. Напишите программу, 
//которая упорядочит по убыванию элементы каждой строки двумерного массива.
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

int [,] SortingArray (int [,] array2D)
{
    int temp = 0;

    for (int i = 0; i < array2D.GetLength(0); i ++)
    {
        for (int j = 0; j < array2D.GetLength(1) - 1; j ++)
        {
            for (int k = j + 1; k < array2D.GetLength(1); k ++)
            {
                if (array2D[i,j] < array2D[i,k])
                {
                    temp = array2D[i,j];
                    array2D[i,j] = array2D[i,k];
                    array2D[i,k] = temp;
                }
            }
        }
    }
    return array2D;
}

int rowsN = 4;
int columnsN = 5;
int minV = new Random().Next(0, 5);
int maxV = new Random().Next(12, 20);

int [,] newArray = Create2DArray(rowsN, columnsN, minV, maxV);
Print2DArray(newArray);
int [,] sortArray = SortingArray(newArray);
Print2DArray(sortArray);
*/

//Задача 56: 
//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
/*
int [,] Create2DArray (int rows, int columns, int min, int max)
{
    int [,] created2DArray = new int [rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            created2DArray[i,j] = new Random().Next(min, max + 1);
    return created2DArray;
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

int [] SumRow (int [,] array2d)
{
    int [] findSum = new int [array2d.GetLength(0)];

    for (int i = 0; i < array2d.GetLength(0); i ++)
    {
        int sum = 0;

        for (int j = 0; j < array2d.GetLength(1); j ++)
            sum = sum + array2d[i,j];
        findSum[i] = sum;
    }
    return findSum;
}

void ShowNumRowMinSum (int [] sumArray)
{
    int minNum = sumArray[0];

    for (int i = 0; i < sumArray.Length; i++)
    { 
        if (sumArray[i] < minNum) 
        {    
            minNum = sumArray[i];
            Console.WriteLine($"Номер строки с наименьшей суммой элементов: {i + 1}");
        }     
    }         
}

int rowsN = 4;
int columnsN = 4;
int minV = new Random().Next(0, 5);
int maxV = new Random().Next(12, 20);

int [,] newArray = Create2DArray(rowsN, columnsN, minV, maxV);
Print2DArray(newArray);
int [] newArraySum = SumRow(newArray);
ShowNumRowMinSum(newArraySum);
*/

//Задача 58: 
//Задайте две матрицы. Напишите программу, 
//которая будет находить произведение двух матриц.
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

int [,] MultiMatrix (int [,] matrixA, int [,] matrixB)
{
    int [,] matrixMulti = new int [matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i ++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j ++)
        {
            matrixMulti[i,j] = 0;

            for (int k = 0; k < matrixA.GetLength(1); k ++)
            {
                matrixMulti[i,j] += matrixA[i,k] * matrixB[k,j];
            }
        }
    }
    return matrixMulti;
}

Console.WriteLine("Введите кол-во строк матрицы A: ");
int rowsA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов матрицы A: ");
int columnsA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк матрицы B: ");
int rowsB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов матрицы B: ");
int columnsB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int minV = new Random().Next(0, 5);
int maxV = new Random().Next(12, 20);

int [,] matrixA = Create2DArray(rowsA, columnsA, minV, maxV);
Console.WriteLine("Матрица A: ");
Print2DArray(matrixA);
int [,] matrixB = Create2DArray(rowsB, columnsB, minV, maxV);
Console.WriteLine("Матрица B: ");
Print2DArray(matrixB);

if (matrixA.GetLength(1) != matrixB.GetLength(0))
    Console.WriteLine("Произведение невозможно!Количество столбцов матрицы A не равно количеству строк матрицы B!");
else
{
    Console.WriteLine("Произведение матриц: ");
    int [,] matrixC = MultiMatrix(matrixA, matrixB);
    Print2DArray(matrixC);
} 
*/

//Задача 60:
//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, 
//добавляя индексы каждого элемента.
/*
int [,,] Create3DArray (int [,,] array3D)
{
    int [] temp = new int [array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
    int number;
    for (int i = 0; i < temp.GetLength(0); i++)
    {  
        temp[i] = new Random().Next(10, 100);
        number = temp[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (temp[i] == temp[j])
                {
                    temp[i] = new Random().Next(10, 100);
                    j = 0;
                    number = temp[i];
                }
                number = temp[i];
            }
        }
    }
    int count = 0;
    for (int x = 0; x < array3D.GetLength(0); x++)    
    {
        for (int y = 0; y < array3D.GetLength(1); y++)
        {
            for (int z = 0; z < array3D.GetLength(2); z++)
            {
                array3D[x,y,z] = temp[count];
                count ++;
            }
        }
    }     
    return array3D;
}

void Print3DArray (int [,,] array3d)
{
    for (int i = 0; i < array3d.GetLength(0); i ++)
    {
        for (int j = 0; j < array3d.GetLength(1); j ++)
        {
            for (int k = 0; k < array3d.GetLength(2); k ++)
            {
                Console.Write($"{array3d[i,j,k]}{(i,j,k)}  ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z: ");
int z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int [,,] new3DArray = new int[x, y ,z];
Create3DArray(new3DArray);
Print3DArray(new3DArray);
*/

//Задача 62. 
//Напишите программу, которая заполнит спирально массив 4 на 4.
/*
void HelixArray (int rows, int columns)
{
    int [,] array = new int [rows, columns];
    int minRow = 0, maxRow = rows - 1, minCol = 0, maxCol = columns - 1;
    int count = 1;
    int maximum = rows * columns;
    while (count < maximum) 
    {
        for (int i = minCol; i <= maxCol; i++) 
        {
            array[minRow,i] = count;
            count++;
        }
        minRow = minRow + 1;
        for (int i = minRow; i <= maxRow; i++) 
        {
            array[i,maxCol] = count;
            count++;
        }
        maxCol = maxCol - 1;
        for (int i = maxCol; i >= minCol; i--) 
        {
            array[maxRow,i] = count;
            count++;
        }
        maxRow = maxRow - 1;
        for (int i = maxRow; i >= minRow; i--) 
        {
            array[i,minCol] = count;
            count++;
        }
        minCol = minCol + 1;
    }
    for (int i = 0; i < rows; i ++) 
    {
        for (int j = 0; j < columns; j ++) 
        {
            Console.Write(String.Format("{0,3}",array[i,j]));
        }
        Console.WriteLine();
    }
}

int rowsN = 4;
int columnsN = 4;

HelixArray(rowsN, columnsN);
*/

