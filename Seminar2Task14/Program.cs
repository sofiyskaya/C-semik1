// Задача №14 Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.


Console.WriteLine("Введите число: ");

// ввели переменную num и присвоили целочисленное значение
int num = Convert.ToInt32(Console.ReadLine());

// ставим два условия одновременно с операндой && - и (также есть || - или; ! - отрицание)
if ((num % 7 == 0) && (num % 23 == 0))
{
    Console.WriteLine($"Число {num} кратно 23 и 7");
}
else
{
    Console.WriteLine($"Число {num} не кратно 23 и 7");   
}

// Console.Write("Введите число: ");
// int num1 = int.Parse(Console.ReadLine()??"0");

// if(num1%23==0 && num1%7==0)
// {
//     Console.WriteLine("Число кратно 7 и 23!");
// } else
// {
//     Console.WriteLine("Число НЕ кратно 23 и 7!");
// }

// Console.Write("Введите первое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// bool bNumber = ((num % 7 == 0) && (num % 23 == 0)); 
// Console.WriteLine(bNumber? $"Число {num} кратно 23 и 7" : $"Число {num} не кратно 23 и 7");