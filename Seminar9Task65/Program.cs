// Задача 65
// Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.

// method reads data from user
int ReadData(string line)
{
    // output message
    Console.WriteLine(line);
    // return value converted to integer
    return Convert.ToInt32(Console.ReadLine()??"0"); 
}

// method prints result
void PrintData(string data)
{
    Console.WriteLine(data);
}

// method gets natural numbers using recursion between M and N
string RecMN(int m, int n)
{
    string res = String.Empty;
    if(m >= n)
    {
        res = n.ToString();
    }
    else
    {
        res = res + m + " " + RecMN(m + 1, n);
    }
    return res;
}

int numM = ReadData("Enter the number M: ");
int numN = ReadData("Enter the number N: ");

string resultLine = numM < numN?RecMN(numM, numN):RecMN(numN, numM);
PrintData(resultLine);