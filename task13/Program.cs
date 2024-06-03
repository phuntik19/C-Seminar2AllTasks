// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

// 645 -> 5
// 78 ->  третьей цифры нет
// 32679 -> 6

int number = Random.Shared.Next(100, 10000);
Console.WriteLine(number);

int firstDigit = number % 100;
int secondDigit = firstDigit / 10;
int thirdDigit = (secondDigit % 10);

if(firstDigit > thirdDigit)
{
    Console.WriteLine(thirdDigit);
}

else 
{
    Console.WriteLine("такой цифры нет");
}


