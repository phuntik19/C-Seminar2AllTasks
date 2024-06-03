// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторкую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int number = Random.Shared.Next(100, 1000);
Console.WriteLine(number);
int firstDigit = (number / 10);
Console.WriteLine(firstDigit);
int midDigit = (firstDigit % 10);
Console.WriteLine(midDigit);
