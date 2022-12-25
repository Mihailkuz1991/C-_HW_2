/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Clear();

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int digit = (int)Math.Log10(num)-2;

if (num < 100)
{
    Console.Write("В заданном числе нет третьей цифры");
}
 
else
    if (digit >= 0)
        {
            int result = num % (int)Math.Pow(10, digit + 1) / (int)Math.Pow(10, digit);
            Console.WriteLine ($"{result} является третей цифрой числа {num}");
        }
    
  
