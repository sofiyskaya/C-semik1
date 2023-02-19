// Задача №16 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// вводим первое число
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

// вводим второе число
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// void - метод не возвращает ничего
void squareTest(int num1, int num2)
{
    // Math.Pow(переменная возводимая в степень, цифра степени)
    if(num1 == Math.Pow(num2,2))
    {
        Console.WriteLine($"Число {num1} является квадратом {num2}");
    }
    else
    {
        Console.WriteLine($"Число {num1} не является квадратом {num2}");
    }
}

squareTest(num1, num2);
squareTest(num2, num1);

