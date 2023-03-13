// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N. Выполнить с помощью рекурсии.

// method reads data from user
int ReadData(string line)
{
    // output message
    Console.WriteLine(line);
    // return value converted to integer
    return Convert.ToInt32(Console.ReadLine()??"0"); 
}

// method gets natural numbers using recursion
void LineGenRec(int num, int numN)
{
    if(num >= numN)
    {
        Console.Write(num + " ");
    }
    else
    {
        Console.Write(num + " ");
        LineGenRec((num +1), numN);
    }
    
}

int number = ReadData("Enter the number N: ");
LineGenRec(1, number);