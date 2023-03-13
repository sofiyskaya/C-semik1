// Задача 67. Напишите программу, которая принимает на вход число и возвращаем сумму цифр этого числа.

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

// method sums the elements of number
int RecSumDig(int num)
{
    if(num == 0)
    {
        return 0;
    }
    else
    {
        return num % 10 + RecSumDig(num / 10);
    }
    
}

int number = ReadData("Enter the number: ");
int result = RecSumDig(number);
PrintData(result);