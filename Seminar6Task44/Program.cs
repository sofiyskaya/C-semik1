// Задача №44 Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

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


string FibNum(int num)
{
    string res = "0 1";
    int first = 0;
    int last = 1;
    for(int i = 2; i < num; i++)
    {
        res = res + (first + last).ToString();
        (first, last) = (last, first + last);
    }
    return res;
}

int num = ReadData("Enter number: ");

PrintData("number: " + FibNum(num));