// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// method reads data from user
int ReadData(string line)
{
    // output message
    Console.WriteLine(line);
    // return value converted to integer
    return Convert.ToInt32(Console.ReadLine()??"0"); 
}

// method prints result
void PrintData(int data)
{
    Console.WriteLine(data);
}

// method gets Akkerman function with recursion
int AkkFunc(int m, int n)
{
    if(m == 0)
    {
        return n + 1;
    }
    if(m > 0 && n == 0)
    {
        return AkkFunc(m - 1, 1);
    }
    return AkkFunc(m - 1, AkkFunc(m, n - 1));
}

int numM = ReadData("Enter the number M: ");
int numN = ReadData("Enter the number N: ");

int result = AkkFunc(numM, numN);
PrintData(result);