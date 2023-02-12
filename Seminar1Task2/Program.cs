// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача №3 
// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.Write("Введите число: ");
// var day = Convert.ToInt32(Console.ReadLine());

// if(day > 7)
// {
//     day = day % 7;

// }

// string[] dayWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
// Console.WriteLine(dayWeek[day-1]);

string? lineDay = Console.ReadLine();
if (lineDay != null)
{
    int day = int.Parse(lineDay);
    string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(day));
        
    Console.WriteLine(outDayOfWeek);

}