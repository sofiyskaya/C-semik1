// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. (c помощью Dictionary)

// объявили словарь и типы данных хранящихся в нем
Dictionary<int, string> dayOfWeek = new Dictionary<int, string>();

// добавили дни недели в словарь
dayOfWeek.Add(1, "Рабочий день");
dayOfWeek.Add(2, "Рабочий день");
dayOfWeek.Add(3, "Рабочий день");
dayOfWeek.Add(4, "Рабочий день");
dayOfWeek.Add(5, "Рабочий день");
dayOfWeek.Add(6, "Выходной день");
dayOfWeek.Add(7, "Выходной день");

// просим ввести день недели, инициализируем новую переменную
Console.Write("Введите день недели числом: ");
int weekDay = int.Parse(Console.ReadLine()??"0");

// проверяем рабочий или выходной день
if(dayOfWeek.ContainsKey(weekDay))
{
    Console.WriteLine(dayOfWeek[weekDay]);
}
else
{
    Console.WriteLine("Это не день недели");
}

