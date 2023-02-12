// See https://aka.ms/new-console-template for more information
// Задача №5
// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.


Console.WriteLine("Введите число: ");
// var day = Convert.ToInt32(Console.ReadLine());
// var negDay = -day;

// for (; negDay <= day; negDay++)
// {
//     Console.WriteLine(negDay+ "\t");
// }

// считываем данные с консоли
string? inputLine = Console.ReadLine();

// проверяем, чтобы данные были не пустыми
if(inputLine != null)
{
    // парсим введенное число
    int inputNumber = int.Parse(inputLine);

    int startNumber = inputNumber*(-1);

    // выходное значение
    string outLine = string.Empty;

    while(startNumber < inputNumber)
    {
        outLine = outLine + startNumber + ", ";
        startNumber++;
        // startNumber = startNumber + 1;
    }
    outLine = outLine + inputNumber;

    // Выводим данные в консоль
    Console.WriteLine(outLine);
}
