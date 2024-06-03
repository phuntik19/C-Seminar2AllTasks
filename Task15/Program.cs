//3.Напишите программу, которая принимает на вход цифру, обозначающую день недели и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
using System;

Console.WriteLine("Введите число");
string? numberString = Console.ReadLine();
int numberInt = Convert.ToInt32(numberString);

if (numberInt == 7)
{
    Console.WriteLine("да");
}

if (numberInt == 6)
{
      Console.WriteLine("да");
}

if (numberInt == 5)
{
    Console.WriteLine("нет");
}

if (numberInt == 4)
{
      Console.WriteLine("нет");
}

if (numberInt == 3)
{
      Console.WriteLine("нет");
}

if (numberInt == 2)
{
    Console.WriteLine("нет");
}

if (numberInt > 8)
{
      Console.WriteLine("такого дня не существует");
}
