// Задача №25. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

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

// method raises the number A to the degree of number B
long Pow(int A, int B)
{
    long res = 1;

    while(B > 0)
    {
        res = res * A;
        B = B - 1;
    }
    return res;
}


int A = ReadData("Enter the number A: ");
int B = ReadData("Enter the number B: ");

long res = Pow(A, B);

PrintData("Result: " + res);