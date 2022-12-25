/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день 
недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/

Console.Clear();

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите число -> {num}");

if (num > 7)
    {
        Console.Write("Некорректное число");
    }

else
    {
        if(num <= 5)
        Console.WriteLine ("Будний день");
        if(num > 5 )
        Console.WriteLine("Выходной");
    }