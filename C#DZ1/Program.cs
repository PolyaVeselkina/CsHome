//Задача 2.
//Напишите программу, которая на вход принимает два числа и выдаёт,
//какое число большее, а какое меньшее.

/*
Console.Write ("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2)
{
    Console.WriteLine($"max = {num_1}");
    Console.WriteLine($"min = {num_2}");
}
else
{
    Console.WriteLine($"max = {num_2}");
    Console.WriteLine($"min = {num_1}");
}
*/




//Задача 4. 
//Напишите программу, которая принимает на вход три числа 
//и выдаёт максимальное из этих чисел.
/*
Console.WriteLine ("Введите 3 числа: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
int num_2 = Convert.ToInt32(Console.ReadLine());
int num_3 = Convert.ToInt32(Console.ReadLine());

int max = num_1;

if (num_2 > max)
{
    max = num_2;
    if (num_3 > max)
    {
        Console.Write (num_3);  
    } 
    else
    {
        Console.Write (num_2); 
    }
}
else
{
    if (num_3 > max)
    {
        Console.Write (num_3);  
    } 
    else
    {
        Console.Write (num_1); 
    }
}
*/




//Задача 6. 
//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write ("Введите число: ");
int num_N = Convert.ToInt32(Console.ReadLine());

if (num_N % 2 == 0)
{
    Console.WriteLine (" четное ");
}
else 
{
    Console.WriteLine (" нечетное ");
}
*/




//Задача 8. 
//Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write ("Введите число: ");
int num_N = Convert.ToInt32(Console.ReadLine());

int current_i = 2;

while(current_i <= num_N)
{
   Console.Write (current_i + " ");
   current_i += 2;  
}
*/

