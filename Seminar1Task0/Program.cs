
Console.WriteLine("Введите число:  ");

// Задача 0
// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное само на себя).

string? inputNum = Console.ReadLine();

// проверяем чтобы данные были не пустыми
if(inputNum != null)
{
    // парсим введенное число
    int number = int.Parse(inputNum);

    // находим квадрат числа
    // int outNum = number*number;
    int outNum = (int)Math.Pow(number,2);

    // выводим данные в консоль
    Console.WriteLine("Квадрат числа:  "+outNum);

    // Console.WriteLine("Квадрат числа: "+Math.Pow(int.Parse(inputNum),2));
}