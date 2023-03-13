// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

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

// method sums natural numbers using recursion between M and N
int RecSumMN(int m, int n)
{
    int res = 0;
    if(m >= n)
    {
        res = n;
    }
    else
    {
        res = res + m + RecSumMN(m + 1, n);
    }
    return res;
}

int numM = ReadData("Enter the number M: ");
int numN = ReadData("Enter the number N: ");

int result = RecSumMN(numM, numN);
PrintData(result);