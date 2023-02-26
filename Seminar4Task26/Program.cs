// Задача 26. Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

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

// method searches the number of digits in the number
int DigitsNumber(int numA)
{
    return (int)Math.Log10(numA) + 1;
}

int numberA = ReadData("Введите число: ");

int res1 = DigitsNumber(numberA);

PrintData("Количество цифр в числе равна: " + res1);