/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 999)
    {
        Console.Write("Введено некорректное число");
    }
else
    {
        int digit1 = num / 100;
        int digit3 = num % 10;
        int result = (num - (digit1 * 100) - digit3) / 10;
        Console.Write(result);
    }
