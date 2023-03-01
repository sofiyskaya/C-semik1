// Задача No28. Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N. (факториал)

// добавили строку чтобы можно было воспользоваться типом данных BigInteger
using System.Numerics;

// method reads data from user
int ReadData(string line)
{
    // output message
    Console.WriteLine(line);
    // return value converted to integer
    return Convert.ToInt32(Console.ReadLine()??"0"); 
}

// method counts factorial of the number
BigInteger FactorCalc (int numA)
{
     BigInteger res = 1;
     for(int i = 2; i<=numA; i++)
     {
        res *= i;
     }
     return res;
}

int numA = ReadData("Enter your number: ");
Console.WriteLine($"The factorial of number is: {FactorCalc(numA)}");