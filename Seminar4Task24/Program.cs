// Задача 24. Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

// method reads data from user
int ReadData(string line)
{
    // output message
    Console.WriteLine(line);
    // return value converted to integer
    return Convert.ToInt32(Console.ReadLine()??"0"); 
}

// method outputs data to the user
void PrintData(string line)
{
    Console.WriteLine(line);
}

//  //method summurizes numbers from 1 to A. numA - число, которое будем накапливать
// int SumSimple(int numA)
// {
//     // сумма, которую будем накапливать
//     int sum = 0; 

//     for(int i=0; i<=numA; i++)
//     {
//         sum+=i;
//         // sum=sum+i;
//     }
//     return sum;
// }

// method summurizes numbers using the Gauss mathematical formula
int SumGausse (int numA)
{
    return ((1 + numA) * numA) / 2;
}

int numberA = ReadData("Введите число А: ");

// int res1 = SumSimple(numberA);
int res1 = SumGausse(numberA);

PrintData("Сумма чисел от 1 до А равна: " + res1);