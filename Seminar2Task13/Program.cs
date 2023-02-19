// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (* сделать вариант для числа длиной до 10 цифр не используя char или string)

// Console.WriteLine("Введите число: ");
// // считываем введенное число
// string num = Console.ReadLine();

// // превращаем число в массив
// char[] arr = num.ToCharArray();

// // выводим третью цифру заданного числа (индексом в массиве - 2)
// Console.WriteLine(arr[2]);


Console.WriteLine("Введите число: ");

int num = Convert.ToInt32(Console.ReadLine());

if (num < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    while(num > 999)
    {
        num /= 10;
    }
    Console.WriteLine("Третья цифра - " + num % 10);
}