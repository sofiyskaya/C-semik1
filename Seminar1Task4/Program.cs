// See https://aka.ms/new-console-template for more information
// Напишите программу, которая принимаем на вход трехзначное число и на выходе показывает последнюю цифру этого числа.
Console.WriteLine("Введите число: ");

int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000)
{
    Console.WriteLine("Последняя цифра числа: " + number % 10);
}
else
Console.WriteLine("Введено неправильное число");