// Задача №42 Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// method reads data from user
int ReadData(string line)
{
    // output message
    Console.WriteLine(line);
    // return value converted to integer
    return Convert.ToInt32(Console.ReadLine()??"0"); 
}

// method prints the result of the sum of the array elements 
void PrintData(string result)
{
    Console.WriteLine(result);
}

string DecToBin(int num)
{
    string res = String.Empty;
    while(num > 0)
    {
        res = num%2 + res;
        num = num/2;
    }
    return res;
}

int num = ReadData("Enter a decimal number: ");

PrintData("binary number: " + DecToBin(num));