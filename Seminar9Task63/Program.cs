// Задача 63. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// method reads data from user
int ReadData(string line)
{
    // output message
    Console.WriteLine(line);
    // return value converted to integer
    return Convert.ToInt32(Console.ReadLine()??"0"); 
}

// method gets natural numbers using recursion
void LineGenRec(int num)
{
    Console.Write(num + " ");
    if(num == 1)
    {

    }
    else
    {
        LineGenRec(num - 1);
    }
    
}

int number = ReadData("Enter the number N: ");
LineGenRec(number);