//Задача 10. 
//Напишите программу, которая принимает на вход трёхзначное число и
//на выходе показывает вторую цифру этого числа.
/*
void Dec (int num)
{    
    if (num > 99 && num < 1000)
    {
        int num1 = num / 10;
        int dec = num1 % 10;
        Console.WriteLine($"Вторая цифра: {dec}");
    }
    else  
    { 
        if (num < -99 && num > -1000) 
        {
            int num1 = num / (-10);
            int dec = num1 % 10;
            Console.WriteLine($"Вторая цифра: {dec}");
        }
        else Console.WriteLine ("Ваше число не трехзначное"); 
    }   
}

Console.WriteLine("Введите число:  ");
int num = Convert.ToInt32(Console.ReadLine());

Dec (num);



//Задача 13. 
//Напишите программу, которая выводит третью цифру заданного числа
//или сообщает, что третьей цифры нет.
/*
void ThirdN1 (int num)
{
    if (num >= 0 && num < 100)
    {
        Console.Write("Нет третей цифры!");
    }
    else 
    {
        while (num >= 1000)
        {
            num = num / 10;
        }
        int numB = num % 10;
        Console.Write("Третья цифра: " + numB);
    }  
}

void ThirdN2 (int num)
{
    if (num < 0 && num > -100)
    {
        Console.Write("Нет третей цифры!");
    }
    else 
    {
        while (num <= -1000)
        {
            num = num / 10;
        }
        int numB = num % 10;
        numB = numB * (-1);
        Console.Write("Третья цифра: " + numB);  
    }  
}

Console.WriteLine("Введите число:  ");
int thirdN = Convert.ToInt32(Console.ReadLine());

if (thirdN >= 0)ThirdN1 (thirdN);
else ThirdN2 (thirdN);
*/

//Задача 15. 
//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
/*
void Day(int day)
{
   if (day > 0 && day < 6)
    {
        Console.WriteLine("Сегодня рабочий день");
    }
    else   
    {   
        if (day > 5 && day < 8)
        {   
            Console.WriteLine("Сегодня выходной день");
        }
        else 
        {
            Console.WriteLine("Нет такого дня недели"); 
        }
    } 
}


Console.WriteLine("Введите число:  ");
int day = Convert.ToInt32(Console.ReadLine());

Day(day);
*/