// Задача 69. Напишите программу, которая будет принимать 2 числа А Б и она возведет А в степень Б с помощью рекурсии.

// method reads data from user
int ReadData(string line)
{
    // output message
    Console.WriteLine(line);
    // return value converted to integer
    return Convert.ToInt32(Console.ReadLine()??"0"); 
}

// method prints result
void PrintData(long data)
{
    Console.WriteLine(data);
}

// 
// long RecPow(int a, int b)
// {
//     if(b <= 1) 
//     {
//         return a;
//     }
//     else
//     {
//         return a * RecPow(a, b - 1);
//     }
// }

// long MyPow(int a, int b)
// {
//     if(b==2)
//     {
//         return 4;
//     }
//     else
//     {
//         return MyPow(a,b/2)*MyPow(a,b/2);
//     }
// }

// универсальный метод, работающий с нечетными числами тоже
long MyPow(int a, int b)
{
    if(b == 2) return a*a;
    if(b == 1) return a;
    if(b % 2 == 0)
    {
        return MyPow(a,b/2)*MyPow(a,b/2);
    }
    else
    {
        return MyPow(a,b/2)*MyPow(a,b/2 + 1);
    }
}

int numA = ReadData("Enter the number A: ");
int numB = ReadData("Enter the number B: ");
long result = MyPow(numA, numB);
PrintData(result);