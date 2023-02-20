// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


// метод, считывающий данные от пользователя
int ReadData(string num)
{
    Console.WriteLine(num);
    return Convert.ToInt32(Console.ReadLine());
}

// метод, который сравнивает первую и пятую цифру и вторую и четвертую. Если они одинаковые, выводит значение true
bool PalinTest(int num)
{
    bool res = false;
    if((num / 10000 == num % 10) && ((num / 1000)%10 == (num/10)%10))
    {
        res = true;
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    }
return res;
}

int PalinNumber = ReadData("Введите пятизначное число: ");
PalinTest(PalinNumber);