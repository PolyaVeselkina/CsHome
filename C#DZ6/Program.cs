//Задача 41: 
//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int Suggest (string message)
{
    Console.WriteLine(message);
    string numBer = Console.ReadLine();
    int val = Convert.ToInt32(numBer);
    return val;
}

int [] InputArray (int size)
{
    int [] array = new int[size];
    for (int i = 0; i < size; i ++)
        array[i] = Suggest($"Введите {i + 1}-й элемент");
    return array;
}

void PrintArray (int [] array1)
{
    for (int i = 0; i < array1.Length; i ++)
        Console.Write (array1[i] + " ");
    Console.WriteLine();
}

int ConstPosNum (int [] array2)
{
    int count = 0;
    for (int i = 0; i < array2.Length; i ++)
        if (array2[i] > 0)
            count ++;
    return count;
}

int lenght = Suggest("Введите кол-во элементов: ");
int [] newArray = InputArray(lenght);
PrintArray(newArray);
Console.WriteLine($"Кол-во чисел больше 0 - {ConstPosNum(newArray)}");
*/

//Задача 43: 
//Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

/*
void FindCoord ( int k1, int k2, int b1, int b2)
{
    double x = Math.Round((double)(b2 - b1) / (k1 - k2), 2);
    double y = Math.Round((k1 * x + b1), 2);
    Console.WriteLine($"Координаты точки пересечения ({x};{y})");
}

Console.WriteLine("Введите k1: ");
int varK1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите k2: ");
int varK2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b1: ");
int varB1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b2: ");
int varB2 = Convert.ToInt32(Console.ReadLine());

FindCoord(varK1, varK2, varB1, varB2);
*/