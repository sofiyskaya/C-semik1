// Задача №27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// * Сделать оценку времени алгоритма через вещественные числа и строки

// method reads data from user
int ReadData(string line)
{
    // output message
    Console.WriteLine(line);
    // return value converted to integer
    return Convert.ToInt32(Console.ReadLine()??"0"); 
}

// method outputs data to the user
void PrintData(string line)
{
    Console.WriteLine(line);
}

// method summurizes the number of digits in the number
int SumDigitsNumber(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }

    return sum;
}

int num = ReadData("Enter your number: ");

int sum = SumDigitsNumber(num);

PrintData("The sum of digits in number: " + sum);