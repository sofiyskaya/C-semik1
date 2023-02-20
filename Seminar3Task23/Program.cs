// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine()??"0");
}

// метод присваивает к каждому числу до N значение и значение N в квадрате(собирает первую и вторую строку в одном методе)
// принимает степень - num и присваевает ей тип string
string LineBuilder(int num, int pow)
{
    // объявили пустую строку res
    string res = string.Empty;
    // заполняем строку res (c первого значения и увеличивая с каждым возвратом на единицу до N)
    for (int i = 1; i <= num; i++)
    {
        // сделали универсальным - Math.Pow(число, степень) - возводит число в степень
        res = res + Math.Pow(i, pow) + "\t";
    }
    return res;
}        

// выводит данные пользователя
int N = ReadData("Введите число: ");
Console.WriteLine(LineBuilder(N, 1));
Console.WriteLine(LineBuilder(N, 3));