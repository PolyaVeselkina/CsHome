//Задача 64
//Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
/*
void ShowNumbers (int numbers)
{
    Console.Write( numbers + " ");
    if (numbers > 1) ShowNumbers(numbers - 1);
}
ShowNumbers(10);
*/

//Задача 66
//Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int FindSum (int m, int n)
{
    if (m <= n) return FindSum (m + 1, n) + m;
    return 0;
}

int resultSum = FindSum(1, 15);
Console.Write(resultSum);
*/

//Задача 68
//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
/*
int Akkerman (int n, int m)
{
    if (n == 0) return (m + 1);
    if (n > 0 && m == 0) return Akkerman(n - 1, 1);
    if (n > 0 && m > 0) return Akkerman(n - 1, Akkerman(n, m - 1));
    return 0;
}

int akkerman = Akkerman(2, 2);
Console.Write(akkerman);
*/






