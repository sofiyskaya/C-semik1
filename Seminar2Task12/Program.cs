// Задача №12 Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число некратно первому, то программа выводит остаток от деления

Console.WriteLine("введите первое число: ");
// объявляем первую переменную, в которую идет введенное число и проверяет на null safety (??)
int firstNum = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("введите второе число: ");
// объявляем вторую переменную, в которую идет введенное число (тоже самое что выше, только медленнее)
int secondNum = Convert.ToInt32(Console.ReadLine());

// сравниваем переменные
int rem = firstNum/secondNum;
if (rem == 0)
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("не кратно, остаток " + rem);
}

